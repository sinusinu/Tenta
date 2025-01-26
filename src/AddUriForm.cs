using System;
using System.Net;
using System.Windows.Forms;

namespace Tenta {
    public partial class AddUriForm : Form {
        public IOTPEntity? otpEntry = null;

        private string? trErrorURIEmpty = "URI cannot be empty!";
        private string? trErrorWrongScheme = "Given URI is invalid! Make sure the URI starts with \"otpauth://\".";
        private string? trErrorOTPTypeNotSupported = "This type of OTP is not supported yet!";
        private string? trErrorURIInvalid = "Given URI is invalid!";

        public AddUriForm() {
            InitializeComponent();
        }

        private void AddUriForm_Load(object sender, EventArgs e) {
            LoadTranslation();
        }

        private void LoadTranslation() {
            LanguageHandler.Instance.TranslateControls([
                this,
                btnOK,
                btnCancel,
            ]);

            LanguageHandler.Instance.GetTranslatedString("AddURI_ErrorURIEmpty", ref trErrorURIEmpty);
            LanguageHandler.Instance.GetTranslatedString("AddURI_ErrorWrongScheme", ref trErrorWrongScheme);
            LanguageHandler.Instance.GetTranslatedString("AddURI_ErrorOTPTypeNotSupported", ref trErrorOTPTypeNotSupported);
            LanguageHandler.Instance.GetTranslatedString("AddURI_ErrorURIInvalid", ref trErrorURIInvalid);
        }

        private void btnOK_Click(object sender, EventArgs e) {
            var uri = tbxUri.Text;

            if (uri is null || uri.Trim().Length == 0) {
                MessageBox.Show(trErrorURIEmpty, "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!uri.StartsWith("otpauth://")) {
                MessageBox.Show(trErrorWrongScheme, "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!uri.StartsWith("otpauth://totp/")) {
                MessageBox.Show(trErrorOTPTypeNotSupported, "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            } catch (Exception) { }

            if (!valid) {
                MessageBox.Show(trErrorURIInvalid, "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            otpEntry = new TOTPEntity(name, issuer, secret, algorithm, digits, period);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
