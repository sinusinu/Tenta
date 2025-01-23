using System;
using System.Net;
using System.Windows.Forms;

namespace Tenta {
    public partial class AddUriForm : Form {
        public IOTPEntity? otpEntry = null;

        public AddUriForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            var uri = tbxUri.Text;

            if (uri is null || uri.Trim().Length == 0) {
                MessageBox.Show("URI cannot be empty!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!uri.StartsWith("otpauth://")) {
                MessageBox.Show("Given URI is invalid! Make sure the URI starts with \"otpauth://\".", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!uri.StartsWith("otpauth://totp/")) {
                MessageBox.Show("This type of OTP is not supported yet!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            } catch (Exception) {}

            if (!valid) {
                MessageBox.Show("Given URI is invalid!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            otpEntry = new TOTPEntity(name, issuer, secret, algorithm, digits, period);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
