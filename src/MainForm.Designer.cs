﻿namespace Tenta
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
            mnuMain = new System.Windows.Forms.MenuStrip();
            tsmManage = new System.Windows.Forms.ToolStripMenuItem();
            tsmAddFromQR = new System.Windows.Forms.ToolStripMenuItem();
            tsmAddFromUri = new System.Windows.Forms.ToolStripMenuItem();
            tsmAddManuallyUri = new System.Windows.Forms.ToolStripMenuItem();
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
            tsmManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmAddFromQR, tsmAddFromUri, tsmAddManuallyUri });
            tsmManage.Name = "tsmManage";
            tsmManage.Size = new System.Drawing.Size(41, 20);
            tsmManage.Text = "&Add";
            // 
            // tsmAddFromQR
            // 
            tsmAddFromQR.Name = "tsmAddFromQR";
            tsmAddFromQR.Size = new System.Drawing.Size(192, 22);
            tsmAddFromQR.Text = "From &QR code...";
            tsmAddFromQR.Click += tsmAddFromQR_Click;
            // 
            // tsmAddFromUri
            // 
            tsmAddFromUri.Name = "tsmAddFromUri";
            tsmAddFromUri.Size = new System.Drawing.Size(192, 22);
            tsmAddFromUri.Text = "From &otpauth:// URI...";
            tsmAddFromUri.Click += tsmAddFromUri_Click;
            // 
            // tsmAddManuallyUri
            // 
            tsmAddManuallyUri.Name = "tsmAddManuallyUri";
            tsmAddManuallyUri.Size = new System.Drawing.Size(192, 22);
            tsmAddManuallyUri.Text = "&Manually...";
            tsmAddManuallyUri.Click += tsmAddManually_Click;
            // 
            // tsmHelp
            // 
            tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsmAbout });
            tsmHelp.Name = "tsmHelp";
            tsmHelp.Size = new System.Drawing.Size(44, 20);
            tsmHelp.Text = "&Help";
            // 
            // tsmAbout
            // 
            tsmAbout.Name = "tsmAbout";
            tsmAbout.Size = new System.Drawing.Size(180, 22);
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
            cmsOtpEntry.Size = new System.Drawing.Size(141, 98);
            // 
            // tsmMoveUpEntry
            // 
            tsmMoveUpEntry.Name = "tsmMoveUpEntry";
            tsmMoveUpEntry.Size = new System.Drawing.Size(140, 22);
            tsmMoveUpEntry.Text = "Move &Up";
            tsmMoveUpEntry.Click += tsmMoveUpEntry_Click;
            // 
            // tsmMoveDownEntry
            // 
            tsmMoveDownEntry.Name = "tsmMoveDownEntry";
            tsmMoveDownEntry.Size = new System.Drawing.Size(140, 22);
            tsmMoveDownEntry.Text = "Move D&own";
            tsmMoveDownEntry.Click += tsmMoveDownEntry_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmEditEntry
            // 
            tsmEditEntry.Name = "tsmEditEntry";
            tsmEditEntry.Size = new System.Drawing.Size(140, 22);
            tsmEditEntry.Text = "&Edit...";
            tsmEditEntry.Click += tsmEditEntry_Click;
            // 
            // tsmDeleteEntry
            // 
            tsmDeleteEntry.Name = "tsmDeleteEntry";
            tsmDeleteEntry.Size = new System.Drawing.Size(140, 22);
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
        private System.Windows.Forms.ToolStripMenuItem tsmAddManuallyUri;
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
