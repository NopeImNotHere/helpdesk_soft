using AdysTech.CredentialManager;
using EF_leer.Views;
using System;
using System.Windows.Forms;
using System.Linq;

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
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Type type = Type.GetType(args[0]);
            Application.Run(new Main_Form((Form)Activator.CreateInstance(type), Convert.ToBoolean(args[1])));
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            if (CredentialManager.GetCredentials("sessionHash") != null)
            {
                CredentialManager.RemoveCredentials("sessionHash");
            }
        }
    }
}
