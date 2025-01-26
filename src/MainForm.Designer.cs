namespace Tenta
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mnuMain = new System.Windows.Forms.MenuStrip();
            tsmManage = new System.Windows.Forms.ToolStripMenuItem();
            tsmAddFromQR = new System.Windows.Forms.ToolStripMenuItem();
            tsmAddFromUri = new System.Windows.Forms.ToolStripMenuItem();
            tsmAddManual = new System.Windows.Forms.ToolStripMenuItem();
            tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            tsmRemainingTime = new System.Windows.Forms.ToolStripMenuItem();
            lbxOtp = new System.Windows.Forms.ListBox();
            cmsOtpEntry = new System.Windows.Forms.ContextMenuStrip(components);
            tsmMoveUpEntry = new System.Windows.Forms.ToolStripMenuItem();
            tsmMoveDownEntry = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsmEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            tsmDeleteEntry = new System.Windows.Forms.ToolStripMenuItem();
            lblEmpty = new System.Windows.Forms.Label();
            mnuMain.SuspendLayout();
            cmsOtpEntry.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmManage, tsmHelp, tsmRemainingTime });
            mnuMain.Location = new System.Drawing.Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new System.Drawing.Size(346, 24);
            mnuMain.TabIndex = 0;
            // 
            // tsmManage
            // 
            tsmManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmAddFromQR, tsmAddFromUri, tsmAddManual });
            tsmManage.Name = "tsmManage";
            tsmManage.Size = new System.Drawing.Size(41, 20);
            tsmManage.Tag = "Main_Menu_Add";
            tsmManage.Text = "&Add";
            // 
            // tsmAddFromQR
            // 
            tsmAddFromQR.Image = (System.Drawing.Image)resources.GetObject("tsmAddFromQR.Image");
            tsmAddFromQR.Name = "tsmAddFromQR";
            tsmAddFromQR.Size = new System.Drawing.Size(192, 22);
            tsmAddFromQR.Tag = "Main_Menu_Add_QR";
            tsmAddFromQR.Text = "From &QR code...";
            tsmAddFromQR.Click += tsmAddFromQR_Click;
            // 
            // tsmAddFromUri
            // 
            tsmAddFromUri.Image = (System.Drawing.Image)resources.GetObject("tsmAddFromUri.Image");
            tsmAddFromUri.Name = "tsmAddFromUri";
            tsmAddFromUri.Size = new System.Drawing.Size(192, 22);
            tsmAddFromUri.Tag = "Main_Menu_Add_URI";
            tsmAddFromUri.Text = "From &otpauth:// URI...";
            tsmAddFromUri.Click += tsmAddFromUri_Click;
            // 
            // tsmAddManual
            // 
            tsmAddManual.Image = (System.Drawing.Image)resources.GetObject("tsmAddManual.Image");
            tsmAddManual.Name = "tsmAddManual";
            tsmAddManual.Size = new System.Drawing.Size(192, 22);
            tsmAddManual.Tag = "Main_Menu_Add_Manual";
            tsmAddManual.Text = "&Manually...";
            tsmAddManual.Click += tsmAddManually_Click;
            // 
            // tsmHelp
            // 
            tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmAbout });
            tsmHelp.Name = "tsmHelp";
            tsmHelp.Size = new System.Drawing.Size(44, 20);
            tsmHelp.Tag = "Main_Menu_Help";
            tsmHelp.Text = "&Help";
            // 
            // tsmAbout
            // 
            tsmAbout.Name = "tsmAbout";
            tsmAbout.Size = new System.Drawing.Size(116, 22);
            tsmAbout.Tag = "Main_Menu_Help_About";
            tsmAbout.Text = "&About...";
            tsmAbout.Click += tsmAbout_Click;
            // 
            // tsmRemainingTime
            // 
            tsmRemainingTime.Name = "tsmRemainingTime";
            tsmRemainingTime.Size = new System.Drawing.Size(12, 20);
            // 
            // lbxOtp
            // 
            lbxOtp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            lbxOtp.Dock = System.Windows.Forms.DockStyle.Fill;
            lbxOtp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            lbxOtp.FormattingEnabled = true;
            lbxOtp.Location = new System.Drawing.Point(0, 24);
            lbxOtp.Name = "lbxOtp";
            lbxOtp.ScrollAlwaysVisible = true;
            lbxOtp.Size = new System.Drawing.Size(346, 606);
            lbxOtp.TabIndex = 1;
            lbxOtp.DrawItem += lbxOtp_DrawItem;
            lbxOtp.MeasureItem += lbxOtp_MeasureItem;
            lbxOtp.DoubleClick += lbxOtp_DoubleClick;
            lbxOtp.MouseUp += lbxOtp_MouseUp;
            // 
            // cmsOtpEntry
            // 
            cmsOtpEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmMoveUpEntry, tsmMoveDownEntry, toolStripSeparator1, tsmEditEntry, tsmDeleteEntry });
            cmsOtpEntry.Name = "cmsOtpEntry";
            cmsOtpEntry.Size = new System.Drawing.Size(181, 120);
            // 
            // tsmMoveUpEntry
            // 
            tsmMoveUpEntry.Name = "tsmMoveUpEntry";
            tsmMoveUpEntry.Size = new System.Drawing.Size(180, 22);
            tsmMoveUpEntry.Tag = "Main_Menu_MoveUp";
            tsmMoveUpEntry.Text = "Move &Up";
            tsmMoveUpEntry.Click += tsmMoveUpEntry_Click;
            // 
            // tsmMoveDownEntry
            // 
            tsmMoveDownEntry.Name = "tsmMoveDownEntry";
            tsmMoveDownEntry.Size = new System.Drawing.Size(180, 22);
            tsmMoveDownEntry.Tag = "Main_Menu_MoveDown";
            tsmMoveDownEntry.Text = "Move D&own";
            tsmMoveDownEntry.Click += tsmMoveDownEntry_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmEditEntry
            // 
            tsmEditEntry.Name = "tsmEditEntry";
            tsmEditEntry.Size = new System.Drawing.Size(180, 22);
            tsmEditEntry.Tag = "Main_Menu_Edit";
            tsmEditEntry.Text = "&Edit...";
            tsmEditEntry.Click += tsmEditEntry_Click;
            // 
            // tsmDeleteEntry
            // 
            tsmDeleteEntry.Name = "tsmDeleteEntry";
            tsmDeleteEntry.Size = new System.Drawing.Size(180, 22);
            tsmDeleteEntry.Tag = "Main_Menu_Delete";
            tsmDeleteEntry.Text = "&Delete";
            tsmDeleteEntry.Click += tsmDeleteEntry_Click;
            // 
            // lblEmpty
            // 
            lblEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            lblEmpty.Location = new System.Drawing.Point(0, 24);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new System.Drawing.Size(346, 606);
            lblEmpty.TabIndex = 2;
            lblEmpty.Tag = "Main_Empty";
            lblEmpty.Text = "No entries to display";
            lblEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(346, 630);
            Controls.Add(lblEmpty);
            Controls.Add(lbxOtp);
            Controls.Add(mnuMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mnuMain;
            MinimumSize = new System.Drawing.Size(300, 0);
            Name = "MainForm";
            Text = "Tenta";
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            cmsOtpEntry.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmManage;
        private System.Windows.Forms.ListBox lbxOtp;
        private System.Windows.Forms.ToolStripMenuItem tsmRemainingTime;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFromUri;
        private System.Windows.Forms.ToolStripMenuItem tsmAddManual;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFromQR;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        private System.Windows.Forms.ContextMenuStrip cmsOtpEntry;
        private System.Windows.Forms.ToolStripMenuItem tsmEditEntry;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteEntry;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveUpEntry;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveDownEntry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblEmpty;
    }
}
