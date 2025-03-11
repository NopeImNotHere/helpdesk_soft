using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                switch (args[0])
                {
                    case "Login":
                        Application.Run(new Login_Form());
                        break;
                    case "Rechnung":
                        Application.Run(new Rechnung_Form());
                        break;
                    case "Ticket":
                        Application.Run(new Ticket_Form());
                        break;
                    default:
                        Application.Run(new Main_Form());
                        break;
                }
            }
            else
            {
                Application.Run(new Main_Form());
            }
        }
    }
}
