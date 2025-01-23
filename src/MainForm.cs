using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System;
using System.Media;
using System.Reflection;

namespace Tenta {
    public partial class MainForm : Form {
        List<IOTPEntity> otpList = new List<IOTPEntity>();

        Font fontTitle;
        Font fontCode;
        Brush brushTitle;
        Brush brushCode;
        StringFormat formatTitle;
        StringFormat formatCode;

        Brush backgroundBrush;
        Brush backgroundEvenBrush;
        Brush selectedBrush;

        Timer tmrUpdate = new Timer();
        int lastRemainingTime = 0;
        Timer tmrHideCopiedMessage = new Timer();
        bool isShowingCopiedMessage = false;

        public MainForm() {
            InitializeComponent();

            if (File.Exists("otp.json")) {
                using (var otpDataJson = JsonDocument.Parse(File.ReadAllText("otp.json"))) {
                    foreach (var otpEntry in otpDataJson.RootElement.EnumerateArray()) {
                        var type = otpEntry.GetProperty("type").GetString();
                        if (type == "totp") {
                            otpList.Add(otpEntry.Deserialize<TOTPEntity>()!);
                        }
                    }
                }
            }

            var fontName = SystemFonts.MessageBoxFont is not null ? SystemFonts.MessageBoxFont.Name : SystemFonts.DefaultFont.Name;
            fontTitle = new Font(fontName, 10, FontStyle.Bold);
            fontCode = new Font(fontName, 12, FontStyle.Bold);

            if (Application.IsDarkModeEnabled) {
                brushTitle = Brushes.White;
                brushCode = Brushes.Salmon;

                backgroundBrush = new SolidBrush(SystemColors.Window);
                backgroundEvenBrush = new SolidBrush(Color.FromArgb(255, Math.Min(255, SystemColors.Window.R + 10), Math.Min(255, SystemColors.Window.G + 10), Math.Min(255, SystemColors.Window.B + 10)));
                selectedBrush = new SolidBrush(Color.FromArgb(255, Math.Min(255, SystemColors.Window.R + 30), Math.Min(255, SystemColors.Window.G + 30), Math.Min(255, SystemColors.Window.B + 30)));
            } else {
                brushTitle = Brushes.Black;
                brushCode = Brushes.Firebrick;

                backgroundBrush = new SolidBrush(SystemColors.Window);
                backgroundEvenBrush = new SolidBrush(Color.FromArgb(255, Math.Max(0, SystemColors.Window.R - 10), Math.Max(0, SystemColors.Window.G - 10), Math.Max(0, SystemColors.Window.B - 10)));
                selectedBrush = new SolidBrush(Color.FromArgb(255, Math.Max(0, SystemColors.Window.R - 30), Math.Max(0, SystemColors.Window.G - 30), Math.Max(0, SystemColors.Window.B - 30)));
            }

            formatTitle = new StringFormat() { Trimming = StringTrimming.EllipsisCharacter, Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };
            formatCode = new StringFormat() { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };

            tmrUpdate.Interval = 500;
            tmrUpdate.Tick += (sender, e) => {
                UpdateOtp();
            };

            tmrHideCopiedMessage.Interval = 1000;
            tmrHideCopiedMessage.Tick += (sender, e) => {
                isShowingCopiedMessage = false;
                tmrHideCopiedMessage.Stop();
            };
        }

        private void UpdateOtp() {
            if (otpList.Count == 0) {
                tsmRemainingTime.Text = "";
                return;
            }

            var remainingTime = otpList[0].GetTimeRemaining();
            if (remainingTime > lastRemainingTime) {
                // remaining time has been reset, should update
                lbxOtp.Invalidate();
            }
            lastRemainingTime = remainingTime;

            if (!isShowingCopiedMessage) tsmRemainingTime.Text = $"Remaining Time: {remainingTime}";
        }

        private void MainForm_Load(object sender, System.EventArgs e) {
            mnuMain.Renderer = new PlainStripRenderer();

            lblEmpty.Visible = (otpList.Count == 0);

            foreach (var otp in otpList) {
                lbxOtp.Items.Add(otp);
            }

            tmrUpdate.Start();
        }

        private void lbxOtp_DrawItem(object sender, DrawItemEventArgs e) {
            if (e.Index == -1) return;
            var otp = otpList[e.Index];

            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus) {
                e.Graphics.FillRectangle(selectedBrush, e.Bounds);
            } else if (e.Index % 2 == 0) {
                e.Graphics.FillRectangle(backgroundEvenBrush, e.Bounds);
            } else {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            var code = otp.GeneratePrettifiedCode();
            var codeTextWidth = (int)e.Graphics.MeasureString(code, fontCode).Width + 2;

            e.Graphics.DrawString(otp.PrettyName, fontTitle, brushTitle, new Rectangle(e.Bounds.X + 10, e.Bounds.Y + (e.Bounds.Height / 2) - (fontTitle.Height / 2), e.Bounds.Width - 20 - codeTextWidth, fontTitle.Height), formatTitle);
            e.Graphics.DrawString(code, fontCode, brushCode, new Rectangle(e.Bounds.X + e.Bounds.Width - codeTextWidth - 10, e.Bounds.Y + 5, codeTextWidth, e.Bounds.Height - 10), formatCode);
        }

        private void lbxOtp_MeasureItem(object sender, MeasureItemEventArgs e) {
            e.ItemHeight = 36;
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            lbxOtp.Invalidate();
        }

        private void lbxOtp_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                lbxOtp.SelectedIndex = lbxOtp.IndexFromPoint(e.Location);
                if (lbxOtp.SelectedIndex != -1) {
                    tsmMoveUpEntry.Enabled = (lbxOtp.SelectedIndex != 0);
                    tsmMoveDownEntry.Enabled = (lbxOtp.SelectedIndex != otpList.Count - 1);
                    cmsOtpEntry.Show(lbxOtp, e.Location);
                }
            }
        }

        private void lbxOtp_DoubleClick(object sender, EventArgs e) {
            if (lbxOtp.SelectedIndex == -1) return;

            var otp = otpList[lbxOtp.SelectedIndex];
            Clipboard.SetText(otp.GenerateCode());

            isShowingCopiedMessage = true;
            tsmRemainingTime.Text = "Copied!";
            tmrHideCopiedMessage.Stop();
            tmrHideCopiedMessage.Start();

            SystemSounds.Beep.Play();
        }

        private void tsmAddFromUri_Click(object sender, EventArgs e) {
            var dialog = new AddUriForm();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK && dialog.otpEntry is not null) {
                otpList.Add(dialog.otpEntry);
                SaveEntries();
                lbxOtp.Items.Add(dialog.otpEntry);
            }
        }

        private void tsmAddManually_Click(object sender, EventArgs e) {
            var dialog = new AddManuallyForm();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK && dialog.otpEntry is not null) {
                otpList.Add(dialog.otpEntry);
                SaveEntries();
                lbxOtp.Items.Add(dialog.otpEntry);
            }
        }

        private void tsmAddFromQR_Click(object sender, EventArgs e) {
            var dialog = new AddQRForm();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK && dialog.otpEntry is not null) {
                otpList.Add(dialog.otpEntry);
                SaveEntries();
                lbxOtp.Items.Add(dialog.otpEntry);
            }
        }

        private void tsmMoveUpEntry_Click(object sender, EventArgs e) {
            var targetIndex = lbxOtp.SelectedIndex;
            var targetEntry = otpList[targetIndex];
            otpList[targetIndex] = otpList[targetIndex - 1];
            otpList[targetIndex - 1] = targetEntry;
            lbxOtp.SelectedIndex = targetIndex - 1;
            SaveEntries();
            lbxOtp.Invalidate();
        }

        private void tsmMoveDownEntry_Click(object sender, EventArgs e) {
            var targetIndex = lbxOtp.SelectedIndex;
            var targetEntry = otpList[targetIndex];
            otpList[targetIndex] = otpList[targetIndex + 1];
            otpList[targetIndex + 1] = targetEntry;
            lbxOtp.SelectedIndex = targetIndex + 1;
            SaveEntries();
            lbxOtp.Invalidate();
        }

        private void tsmEditEntry_Click(object sender, EventArgs e) {
            var targetIndex = lbxOtp.SelectedIndex;
            var dialog = new EditEntryForm(otpList[targetIndex]);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK) {
                otpList.RemoveAt(targetIndex);
                otpList.Insert(targetIndex, dialog.otpEntry);
                SaveEntries();
                lbxOtp.Invalidate();
            }
        }

        private void tsmDeleteEntry_Click(object sender, EventArgs e) {
            var targetIndex = lbxOtp.SelectedIndex;
            if (MessageBox.Show($"Delete OTP entry \"{otpList[targetIndex].PrettyName}\"?", "Tenta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                otpList.RemoveAt(targetIndex);
                SaveEntries();
                lbxOtp.Items.RemoveAt(targetIndex);
                lbxOtp.Invalidate();
            }
        }

        private void SaveEntries() {
            lblEmpty.Visible = (otpList.Count == 0);
            var otpListExport = JsonSerializer.Serialize(otpList, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText("otp.json", otpListExport);
        }

        private void tsmAbout_Click(object sender, EventArgs e) {
            TaskDialog.ShowDialog(this, new TaskDialogPage() {
                Caption = "About",
                Heading = $"Tenta {Assembly.GetExecutingAssembly().GetName()!.Version}",
                Text = "A WinForms OTP client because why not\n\n© 2025 sinu",
                Icon = TaskDialogIcon.Information,
                Buttons = { TaskDialogButton.Close },
            });
        }
    }
}

