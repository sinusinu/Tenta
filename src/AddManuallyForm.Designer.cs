namespace Tenta {
    partial class AddManuallyForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddManuallyForm));
            label1 = new System.Windows.Forms.Label();
            tbxUsername = new System.Windows.Forms.TextBox();
            tbxIssuer = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tbxSecret = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            tbxDigits = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            tbxPeriod = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnOK = new System.Windows.Forms.Button();
            cbxAlgorithm = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 23);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxUsername
            // 
            tbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxUsername.Location = new System.Drawing.Point(92, 9);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new System.Drawing.Size(192, 23);
            tbxUsername.TabIndex = 1;
            // 
            // tbxIssuer
            // 
            tbxIssuer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxIssuer.Location = new System.Drawing.Point(92, 38);
            tbxIssuer.Name = "tbxIssuer";
            tbxIssuer.Size = new System.Drawing.Size(192, 23);
            tbxIssuer.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(74, 23);
            label2.TabIndex = 2;
            label2.Text = "Issuer";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxSecret
            // 
            tbxSecret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxSecret.Location = new System.Drawing.Point(92, 67);
            tbxSecret.Name = "tbxSecret";
            tbxSecret.Size = new System.Drawing.Size(192, 23);
            tbxSecret.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 67);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 23);
            label3.TabIndex = 4;
            label3.Text = "Secret";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(12, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 23);
            label4.TabIndex = 6;
            label4.Text = "Algorithm";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxDigits
            // 
            tbxDigits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxDigits.Location = new System.Drawing.Point(92, 125);
            tbxDigits.Name = "tbxDigits";
            tbxDigits.Size = new System.Drawing.Size(192, 23);
            tbxDigits.TabIndex = 9;
            tbxDigits.Text = "6";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(12, 125);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(74, 23);
            label5.TabIndex = 8;
            label5.Text = "Digits";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxPeriod
            // 
            tbxPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tbxPeriod.Location = new System.Drawing.Point(92, 154);
            tbxPeriod.Name = "tbxPeriod";
            tbxPeriod.Size = new System.Drawing.Size(192, 23);
            tbxPeriod.TabIndex = 11;
            tbxPeriod.Text = "30";
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(12, 154);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(74, 23);
            label6.TabIndex = 10;
            label6.Text = "Period";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnCancel.Location = new System.Drawing.Point(209, 190);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnOK.Location = new System.Drawing.Point(128, 190);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(75, 23);
            btnOK.TabIndex = 12;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
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
            cbxAlgorithm.TabIndex = 13;
            // 
            // AddManuallyForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(296, 225);
            Controls.Add(cbxAlgorithm);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(tbxPeriod);
            Controls.Add(label6);
            Controls.Add(tbxDigits);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbxSecret);
            Controls.Add(label3);
            Controls.Add(tbxIssuer);
            Controls.Add(label2);
            Controls.Add(tbxUsername);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddManuallyForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Manually";
            Load += AddManuallyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxIssuer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSecret;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDigits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxAlgorithm;
    }
}