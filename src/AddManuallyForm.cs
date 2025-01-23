using OtpNet;
using System;
using System.Windows.Forms;

namespace Tenta {
    public partial class AddManuallyForm : Form {
        public IOTPEntity? otpEntry;

        public AddManuallyForm() {
            InitializeComponent();
        }

        private void AddManuallyForm_Load(object sender, EventArgs e) {
            cbxAlgorithm.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e) {
            if (tbxUsername.Text.Trim().Length == 0 || tbxSecret.Text.Trim().Length == 0) {
                MessageBox.Show("Username and Secret are required!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int digits = 6;
            int period = 30;

            try {
                digits = int.Parse(tbxDigits.Text);
                period = int.Parse(tbxPeriod.Text);
            } catch (Exception) {
                MessageBox.Show("Digits and Period must be numbers only!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try {
                Base32Encoding.ToBytes(tbxSecret.Text);
            } catch (Exception) {
                MessageBox.Show("Given Secret is invalid!", "Tenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
