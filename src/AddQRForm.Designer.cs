namespace Tenta {
    partial class AddQRForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQRForm));
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            pbxImage = new System.Windows.Forms.PictureBox();
            btnLoadImageFromFile = new System.Windows.Forms.Button();
            btnLoadImageFromClipboard = new System.Windows.Forms.Button();
            lblSelectImage = new System.Windows.Forms.Label();
            lblError = new System.Windows.Forms.Label();
            ofdDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbxImage).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnOK.Location = new System.Drawing.Point(211, 253);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(75, 23);
            btnOK.TabIndex = 13;
            btnOK.Tag = "Common_OK";
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnCancel.Location = new System.Drawing.Point(292, 253);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Tag = "Common_Cancel";
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // pbxImage
            // 
            pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbxImage.Location = new System.Drawing.Point(12, 12);
            pbxImage.Name = "pbxImage";
            pbxImage.Size = new System.Drawing.Size(232, 232);
            pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbxImage.TabIndex = 15;
            pbxImage.TabStop = false;
            // 
            // btnLoadImageFromFile
            // 
            btnLoadImageFromFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnLoadImageFromFile.Location = new System.Drawing.Point(250, 35);
            btnLoadImageFromFile.Name = "btnLoadImageFromFile";
            btnLoadImageFromFile.Size = new System.Drawing.Size(117, 23);
            btnLoadImageFromFile.TabIndex = 16;
            btnLoadImageFromFile.Tag = "AddQR_FromFile";
            btnLoadImageFromFile.Text = "from File";
            btnLoadImageFromFile.UseVisualStyleBackColor = true;
            btnLoadImageFromFile.Click += btnLoadImageFromFile_Click;
            // 
            // btnLoadImageFromClipboard
            // 
            btnLoadImageFromClipboard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnLoadImageFromClipboard.Location = new System.Drawing.Point(250, 64);
            btnLoadImageFromClipboard.Name = "btnLoadImageFromClipboard";
            btnLoadImageFromClipboard.Size = new System.Drawing.Size(117, 23);
            btnLoadImageFromClipboard.TabIndex = 18;
            btnLoadImageFromClipboard.Tag = "AddQR_FromClipboard";
            btnLoadImageFromClipboard.Text = "from Clipboard";
            btnLoadImageFromClipboard.UseVisualStyleBackColor = true;
            btnLoadImageFromClipboard.Click += btnLoadImageFromClipboard_Click;
            // 
            // lblSelectImage
            // 
            lblSelectImage.Location = new System.Drawing.Point(250, 9);
            lblSelectImage.Name = "lblSelectImage";
            lblSelectImage.Size = new System.Drawing.Size(117, 23);
            lblSelectImage.TabIndex = 19;
            lblSelectImage.Tag = "AddQR_SelectImage";
            lblSelectImage.Text = "Select an image";
            lblSelectImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblError
            // 
            lblError.Location = new System.Drawing.Point(12, 253);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(193, 23);
            lblError.TabIndex = 20;
            lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ofdDialog
            // 
            ofdDialog.AddToRecent = false;
            ofdDialog.Filter = "JPG, PNG|*.jpg;*.png|All files|*.*";
            // 
            // AddQRForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(379, 288);
            Controls.Add(lblError);
            Controls.Add(lblSelectImage);
            Controls.Add(btnLoadImageFromClipboard);
            Controls.Add(btnLoadImageFromFile);
            Controls.Add(pbxImage);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddQRForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Tag = "AddQR_Title";
            Text = "Add from QR code";
            Load += AddQRForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnLoadImageFromFile;
        private System.Windows.Forms.Button btnLoadImageFromClipboard;
        private System.Windows.Forms.Label lblSelectImage;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.OpenFileDialog ofdDialog;
    }
}