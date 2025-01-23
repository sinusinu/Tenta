using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.Windows.Compatibility;

namespace Tenta {
    public partial class AddQRForm : Form {
        public IOTPEntity? otpEntry;
        QRCodeReader qrReader = new QRCodeReader();
        Bitmap? bmImage = null;

        public AddQRForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (otpEntry is null) {
                MessageBox.Show("No vaild image is loaded!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnLoadImageFromFile_Click(object sender, EventArgs e) {
            if (ofdDialog.ShowDialog() == DialogResult.OK) {
                pbxImage.Image = Image.FromFile(ofdDialog.FileName);
                if (bmImage != null) bmImage.Dispose();
                bmImage = new Bitmap(ofdDialog.FileName);

                TryDecodeImage();
            }
        }

        private void btnLoadImageFromClipboard_Click(object sender, EventArgs e) {
            if (Clipboard.ContainsImage()) {
                pbxImage.Image = Clipboard.GetImage();
                if (bmImage != null) bmImage.Dispose();
                bmImage = new Bitmap(Clipboard.GetImage()!);
            } else {
                MessageBox.Show("No image found on Clipboard!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TryDecodeImage();
        }

        private void TryDecodeImage() {
            otpEntry = null;

            var decodeResult = qrReader.decode(new BinaryBitmap(new HybridBinarizer(new BitmapLuminanceSource(bmImage))));
            if (decodeResult is null) {
                lblError.Text = "No QR code found";
            } else {
                otpEntry = DecodeOtpUri(decodeResult.Text);
                if (otpEntry is null) {
                    lblError.Text = "No OTP data found";
                } else {
                    lblError.Text = "OK";
                }
            }
        }

        private IOTPEntity? DecodeOtpUri(string uri) {
            if (uri is null || uri.Trim().Length == 0) {
                return null;
            }

            if (!uri.StartsWith("otpauth://")) {
                return null;
            }

            if (!uri.StartsWith("otpauth://totp/")) {
                return null;
            }

            bool valid = false;

            string name = "";
            string issuer = "";
            string secret = "";
            string algorithm = "SHA1";
            int digits = 6;
            int period = 30;

            try {
                uri = uri.Substring(15);
                var uris = uri.Split('?', 2);
                var uriParameters = uris[1].Split('&');

                name = WebUtility.UrlDecode(uris[0]);

                foreach (var param in uriParameters) {
                    var paramSplit = param.Split('=', 2);
                    var paramName = paramSplit[0];
                    var paramValue = paramSplit[1];

                    if (paramName == "issuer") issuer = WebUtility.UrlDecode(paramValue);
                    else if (paramName == "secret") { secret = WebUtility.UrlDecode(paramValue); valid = true; } else if (paramName == "algorithm") algorithm = WebUtility.UrlDecode(paramValue);
                    else if (paramName == "digits") digits = int.Parse(paramValue);
                    else if (paramName == "period") period = int.Parse(paramValue);
                }
            } catch (Exception) { }

            if (!valid) {
                return null;
            }

            otpEntry = new TOTPEntity(name, issuer, secret, algorithm, digits, period);
            return otpEntry;
        }
    }
}
