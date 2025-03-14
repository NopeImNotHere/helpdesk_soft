using AdysTech.CredentialManager;
using EF_leer.util;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace EF_leer
{
    public partial class Login_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();
        NetworkCredential creds = new NetworkCredential();

        public Login_Form()
        {
            InitializeComponent();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Willst du diese App verlassen", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                if (CredentialManager.GetCredentials("sessionHash") != null)
                {
                    base.OnFormClosing(e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string email = EMail_Field.Text;
            string hashed_password = LoginHelper.HashPassword(Password_Field.Text);
            dynamic match = null;

            match = data.mitarbeiter.FirstOrDefault(mitarbeiter => mitarbeiter.Email.Equals(email) && mitarbeiter.Passwort.Equals(hashed_password));
            if (match != null)
            {
                mitarbeiter mitarbeiter = (mitarbeiter)match;
                string sessionHash = LoginHelper.CreateSessionHash(mitarbeiter.PK_Mitarbeiter, hashed_password);
                creds.UserName = email;
                creds.Password = sessionHash;
                CredentialManager.SaveCredentials("sessionHash", creds);

                session newSession = new session
                {
                    sessionhash = sessionHash,
                    expires_at = DateTime.Now.AddHours(3),
                    inserted_at = DateTime.Now,
                    mitarbeiter = mitarbeiter,
                    kunde = null
                };
                data.session.Add(newSession);
                this.Close();
            }

            match = data.kunde.FirstOrDefault(kunde => kunde.Email.Equals(email) && kunde.Passwort.Equals(hashed_password));
            if (match != null)
            {
                kunde kunde = (kunde)match;
                string sessionHash = LoginHelper.CreateSessionHash(kunde.PK_Kunde, hashed_password);
                creds.UserName = email;
                creds.Password = sessionHash;
                CredentialManager.SaveCredentials("sessionHash", creds);

                session newSession = new session
                {
                    sessionhash = sessionHash,
                    expires_at = DateTime.Now.AddHours(3),
                    inserted_at = DateTime.Now,
                    kunde = kunde,
                    mitarbeiter = null
                };
                data.session.Add(newSession);
                this.Close();
            }
        }
    }
}
