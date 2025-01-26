using OtpNet;
using System;
using System.Net.Sockets;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Tenta {
    public partial class AddManuallyForm : Form {
        public IOTPEntity? otpEntry;

        private string? trErrorMissingRequired = "Username and Secret are required!";
        private string? trErrorNotNumbers = "Digits and Period must be numbers only!";
        private string? trErrorInvalidSecret = "Given Secret is invalid!";

        public AddManuallyForm() {
            InitializeComponent();
        }

        private void AddManuallyForm_Load(object sender, EventArgs e) {
            LoadTranslation();

            cbxAlgorithm.SelectedIndex = 0;
        }

        private void LoadTranslation() {
            LanguageHandler.Instance.TranslateControls([
                this,
                lblUsername,
                lblIssuer,
                lblSecret,
                lblAlgorithm,
                lblDigits,
                lblPeriod,
                btnOK,
                btnCancel
            ]);

            LanguageHandler.Instance.GetTranslatedString("AddManual_Error_MissingRequired", ref trErrorMissingRequired);
            LanguageHandler.Instance.GetTranslatedString("AddManual_Error_NotNumbers", ref trErrorNotNumbers);
            LanguageHandler.Instance.GetTranslatedString("AddManual_Error_InvalidSecret", ref trErrorInvalidSecret);
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (tbxUsername.Text.Trim().Length == 0 || tbxSecret.Text.Trim().Length == 0) {
                MessageBox.Show(trErrorMissingRequired, "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int digits = 6;
            int period = 30;

            try {
                digits = int.Parse(tbxDigits.Text);
                period = int.Parse(tbxPeriod.Text);
            } catch (Exception) {
                MessageBox.Show(trErrorNotNumbers, "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                Base32Encoding.ToBytes(tbxSecret.Text);
            } catch (Exception) {
                MessageBox.Show(trErrorInvalidSecret, "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var algorithm = "";
            switch (cbxAlgorithm.SelectedIndex) {
                case 0: algorithm = "sha1"; break;
                case 1: algorithm = "sha256"; break;
                case 2: algorithm = "sha512"; break;
            }

            otpEntry = new TOTPEntity(tbxUsername.Text, tbxIssuer.Text, tbxSecret.Text, algorithm, digits, period);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
