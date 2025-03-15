using AdysTech.CredentialManager;
using System;
using System.Windows.Forms;

namespace EF_leer
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length != 0)
            {
                Application.Run(new Main_Form(args[0]));
            }
            else
            {
                Application.Run(new Main_Form(""));
            }
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            CredentialManager.RemoveCredentials("sessionHash");
        }
    }
}
