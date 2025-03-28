using AdysTech.CredentialManager;
using EF_leer.Views;
using System;
using System.Linq;
using System.Net;
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
            //Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Type type = Type.GetType(args[0]);
            Application.Run(new Main_Form((Form)Activator.CreateInstance(type), Convert.ToBoolean(args[1])));
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            using (oberstufe_db1Entities data = new oberstufe_db1Entities())
            {
                NetworkCredential creds = CredentialManager.GetCredentials("sessionHash");
                session session = data.session.Where(s => s.sessionhash == creds.Password).FirstOrDefault();
                data.session.Remove(session);
                data.SaveChanges();
            }

            if (CredentialManager.GetCredentials("sessionHash") != null)
            {
                CredentialManager.RemoveCredentials("sessionHash");
            }
        }
    }
}
