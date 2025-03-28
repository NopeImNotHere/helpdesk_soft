using AdysTech.CredentialManager;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class Main_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();

        private Main_Form()
        {
            InitializeComponent();
            NetworkCredential temp = CredentialManager.GetCredentials("sessionHash");
            if (CredentialManager.GetCredentials("sessionHash") == null && !System.Diagnostics.Debugger.IsAttached)
            {
                MessageBox.Show("Illegaler Zugriff schließe Programm");
                this.Close();
                return;
            }
            else if (CredentialManager.GetCredentials("sessionHash") != null)
            {
                NetworkCredential creds = CredentialManager.GetCredentials("sessionHash");
                string sessionHash = creds.Password;
                session session = data.session.Where(s => s.sessionhash == sessionHash).FirstOrDefault();

                if (session != null)
                {
                    if (session.kunde != null)
                    {
                        profileStripMenuItem.Text = $"Logged als {session.kunde.Firmenname}";
                    }
                    else if (session.mitarbeiter != null)
                    {
                        profileStripMenuItem.Text = $"Logged als {session.mitarbeiter.Vorname} {session.mitarbeiter.Nachname}";
                    }
                }
            }
        }
        public Main_Form(Form form, bool isDialog) : this()
        {
            windowLauncher(form, isDialog);
        }

        public void windowLauncher(Form form, bool isDialog)
        {
            if (form == null)
            {
                form = new Main_Form();
                isDialog = false;
            }

            if (isDialog)
            {
                form.Owner = this;
                form.ShowDialog();
            }
            else
            {
                ShowChildForm(form);
            }
        }
        private void ShowChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ClientSize = childForm.Size;
            childForm.Show();
            if (childForm is User_Form form)
            {
                form.FormClosed += (s, e) =>
                {
                    if (form.isLoggedOut)
                    {
                        this.Hide();
                        windowLauncher(new Login_Form(), true);
                    }
                };
            }

        }

        private void rechnungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowLauncher(new Rechnung_Form(), false);
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowLauncher(new Ticket_Form(), false);
        }

        private void profileStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkCredential creds = CredentialManager.GetCredentials("sessionHash");
            if (creds == null)
            {
                windowLauncher(new User_Form(), false);
            }

            string sessionHash = creds.Password;
            session session = data.session.Where(s => s.sessionhash == sessionHash).First();
            if (session.mitarbeiter != null)
            {
                windowLauncher(new Mitarbeiter_Form(), false);
            }
            else if (session.kunde != null)
            {
                windowLauncher(new User_Form(session.kunde), false);
            }
        }

        private void neuErstellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowLauncher(new Erstellen(), false);
        }
    }
}
