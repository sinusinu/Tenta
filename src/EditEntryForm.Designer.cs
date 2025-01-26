namespace Tenta {
    partial class EditEntryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEntryForm));
            cbxAlgorithm = new System.Windows.Forms.ComboBox();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            tbxPeriod = new System.Windows.Forms.TextBox();
            tbxDigits = new System.Windows.Forms.TextBox();
            tbxSecret = new System.Windows.Forms.TextBox();
            tbxIssuer = new System.Windows.Forms.TextBox();
            tbxUsername = new System.Windows.Forms.TextBox();
            lblPeriod = new System.Windows.Forms.Label();
            lblDigits = new System.Windows.Forms.Label();
            lblAlgorithm = new System.Windows.Forms.Label();
            lblSecret = new System.Windows.Forms.Label();
            lblIssuer = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbxAlgorithm
            // 
            cbxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cbxAlgorithm.FormattingEnabled = true;
            cbxAlgorithm.Items.AddRange(new object[] { "SHA-1", "SHA-256", "SHA-512" });
            cbxAlgorithm.Location = new System.Drawing.Point(92, 97);
            cbxAlgorithm.Name = "cbxAlgorithm";
            cbxAlgorithm.Size = new System.Drawing.Size(192, 23);
            cbxAlgorithm.TabIndex = 27;
            // 
            // btnOK
            // 
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnOK.Location = new System.Drawing.Point(128, 190);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(75, 23);
            btnOK.TabIndex = 25;
            btnOK.Tag = "Common_OK";
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnCancel.Location = new System.Drawing.Point(209, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 26;
            btnCancel.Tag = "Common_Cancel";
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxPeriod
            // 
            tbxPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxPeriod.Location = new System.Drawing.Point(92, 154);
            tbxPeriod.Name = "tbxPeriod";
            tbxPeriod.Size = new System.Drawing.Size(192, 23);
            tbxPeriod.TabIndex = 24;
            // 
            // tbxDigits
            // 
            tbxDigits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxDigits.Location = new System.Drawing.Point(92, 125);
            tbxDigits.Name = "tbxDigits";
            tbxDigits.Size = new System.Drawing.Size(192, 23);
            tbxDigits.TabIndex = 22;
            // 
            // tbxSecret
            // 
            tbxSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxSecret.Location = new System.Drawing.Point(92, 67);
            tbxSecret.Name = "tbxSecret";
            tbxSecret.Size = new System.Drawing.Size(192, 23);
            tbxSecret.TabIndex = 19;
            // 
            // tbxIssuer
            // 
            tbxIssuer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxIssuer.Location = new System.Drawing.Point(92, 38);
            tbxIssuer.Name = "tbxIssuer";
            tbxIssuer.Size = new System.Drawing.Size(192, 23);
            tbxIssuer.TabIndex = 17;
            // 
            // tbxUsername
            // 
            tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxUsername.Location = new System.Drawing.Point(92, 9);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new System.Drawing.Size(192, 23);
            tbxUsername.TabIndex = 15;
            // 
            // lblPeriod
            // 
            lblPeriod.Location = new System.Drawing.Point(12, 154);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new System.Drawing.Size(74, 23);
            lblPeriod.TabIndex = 33;
            lblPeriod.Tag = "AddManual_Period";
            lblPeriod.Text = "Period";
            lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDigits
            // 
            lblDigits.Location = new System.Drawing.Point(12, 125);
            lblDigits.Name = "lblDigits";
            lblDigits.Size = new System.Drawing.Size(74, 23);
            lblDigits.TabIndex = 32;
            lblDigits.Tag = "AddManual_Digits";
            lblDigits.Text = "Digits";
            lblDigits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAlgorithm
            // 
            lblAlgorithm.Location = new System.Drawing.Point(12, 96);
            lblAlgorithm.Name = "lblAlgorithm";
            lblAlgorithm.Size = new System.Drawing.Size(74, 23);
            lblAlgorithm.TabIndex = 31;
            lblAlgorithm.Tag = "AddManual_Algorithm";
            lblAlgorithm.Text = "Algorithm";
            lblAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSecret
            // 
            lblSecret.Location = new System.Drawing.Point(12, 67);
            lblSecret.Name = "lblSecret";
            lblSecret.Size = new System.Drawing.Size(74, 23);
            lblSecret.TabIndex = 30;
            lblSecret.Tag = "AddManual_Secret";
            lblSecret.Text = "Secret";
            lblSecret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIssuer
            // 
            lblIssuer.Location = new System.Drawing.Point(12, 38);
            lblIssuer.Name = "lblIssuer";
            lblIssuer.Size = new System.Drawing.Size(74, 23);
            lblIssuer.TabIndex = 29;
            lblIssuer.Tag = "AddManual_Issuer";
            lblIssuer.Text = "Issuer";
            lblIssuer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsername
            // 
            lblUsername.Location = new System.Drawing.Point(12, 9);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(74, 23);
            lblUsername.TabIndex = 28;
            lblUsername.Tag = "AddManual_Username";
            lblUsername.Text = "Username";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditEntryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(296, 225);
            Controls.Add(lblPeriod);
            Controls.Add(lblDigits);
            Controls.Add(lblAlgorithm);
            Controls.Add(lblSecret);
            Controls.Add(lblIssuer);
            Controls.Add(lblUsername);
            Controls.Add(cbxAlgorithm);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(tbxPeriod);
            Controls.Add(tbxDigits);
            Controls.Add(tbxSecret);
            Controls.Add(tbxIssuer);
            Controls.Add(tbxUsername);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "EditEntryForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Tag = "Edit_Title";
            Text = "Edit";
            Load += EditEntryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAlgorithm;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxPeriod;
        private System.Windows.Forms.TextBox tbxDigits;
        private System.Windows.Forms.TextBox tbxSecret;
        private System.Windows.Forms.TextBox tbxIssuer;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.Label lblAlgorithm;
        private System.Windows.Forms.Label lblSecret;
        private System.Windows.Forms.Label lblIssuer;
        private System.Windows.Forms.Label lblUsername;
    }
}