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
        public Main_Form(string launchFormName)
        {
            InitializeComponent();
            windowLauncher(launchFormName);
            this.FormClosing += Main_Form_FormClosing;

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
                session session = data.session.Where(s => s.sessionhash == sessionHash).First();

                if (session.kunde != null)
                {
                    profileStripMenuItem.Text = $"Logged als {session.kunde.Firmenname}";
                }
                else
                {
                    profileStripMenuItem.Text = $"Logged als {session.mitarbeiter.Vorname} {session.mitarbeiter.Nachname}";
                }
            }
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void windowLauncher(string formName)
        {
            Form form;
            switch (formName)
            {
                case "Login":
                    form = new Login_Form();
                    form.Owner = this;
                    form.ShowDialog();
                    break;
                case "Rechnung":
                    form = new Rechnung_Form();
                    ShowChildForm(form);
                    break;
                case "Ticket":
                    form = new Ticket_Form();
                    ShowChildForm(form);
                    break;
                case "Mitarbeiter":
                    form = new Mitarbeiter_Form();
                    ShowChildForm(form);
                    break;
                case "Kunde":
                    form = new Kunde_Form();
                    ShowChildForm(form);
                    break;
                default:
                    break;
            }
        }
        private void ShowChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.ClientSize = childForm.Size;
            childForm.Show();
            if (childForm is Mitarbeiter_Form form)
            {
                form.FormClosed += (s, e) =>
                {
                    if (form.isLoggedOut)
                    {
                        this.Hide();
                        windowLauncher("Login");
                    }
                };
            }
            else if (childForm is Kunde_Form form2)
            {
                form2.FormClosed += (s, e) =>
                {
                    if (form2.isLoggedOut)
                    {
                        this.Hide();
                        windowLauncher("Login");
                    }
                };
            }

        }

        private void rechnungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowLauncher("Rechnung");
        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowLauncher("Ticket");
        }

        private void profileStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkCredential creds = CredentialManager.GetCredentials("sessionHash");
            if (creds == null)
            {
                windowLauncher("Mitarbeiter");
            }

            string sessionHash = creds.Password;
            session session = data.session.Where(s => s.sessionhash == sessionHash).First();
            if (session.mitarbeiter != null)
            {
                windowLauncher("Mitarbeiter");
            }
            else if (session.kunde != null)
            {
                windowLauncher("Kunde");
            }
        }
    }
}
