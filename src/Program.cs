using System;
using System.Windows.Forms;

namespace Tenta {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.SetColorMode(SystemColorMode.System);
            Application.Run(new MainForm());
        }
    }
}