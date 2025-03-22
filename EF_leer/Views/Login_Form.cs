using AdysTech.CredentialManager;
using EF_leer.util;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class Login_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();
        NetworkCredential creds = new NetworkCredential();

        public Login_Form()
        {
            InitializeComponent();


        }

        public Login_Form(string username, string password)
        {
            InitializeComponent();
            EMail_Field.Text = username;
            Password_Field.Text = password;
            System.Threading.Thread.Sleep(5);
            Login_Click(this, EventArgs.Empty);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DialogResult result;
            if (CredentialManager.GetCredentials("sessionHash") == null)
            {
                result = MessageBox.Show("Willst du diese App verlassen", "Exit", MessageBoxButtons.YesNo);
            }
            else
            {
                result = DialogResult.No;
            }

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
            if (email == string.Empty || Password_Field.Text == string.Empty)
            {
                MessageBox.Show("Entweder die EMail oder das Passwort ist falsch", "Falscher Login", MessageBoxButtons.OK);
                return;
            }

            dynamic match = null;
            string sessionHash = "";
            mitarbeiter sessionMitarbeiter = null;
            kunde sessionKunde = null;

            match = data.mitarbeiter.FirstOrDefault(mitarbeiter => mitarbeiter.Email.Equals(email) && mitarbeiter.Passwort.Equals(hashed_password));
            if (match != null)
            {
                sessionMitarbeiter = (mitarbeiter)match;
                sessionHash = LoginHelper.CreateSessionHash(sessionMitarbeiter.PK_Mitarbeiter, hashed_password);
                creds.UserName = email;
                creds.Password = sessionHash;
                CredentialManager.SaveCredentials("sessionHash", creds);
            }

            match = data.kunde.FirstOrDefault(kunde => kunde.Email.Equals(email) && kunde.Passwort.Equals(hashed_password));
            if (match != null)
            {
                sessionKunde = (kunde)match;
                sessionHash = LoginHelper.CreateSessionHash(sessionKunde.PK_Kunde, hashed_password);
                creds.UserName = email;
                creds.Password = sessionHash;
                CredentialManager.SaveCredentials("sessionHash", creds);
            }

            if (CredentialManager.GetCredentials("sessionHash") == null)
            {
                MessageBox.Show("Entweder die EMail oder das Passwort ist falsch", "Falscher Login", MessageBoxButtons.OK);
                return;
            }

            if (data.session.FirstOrDefault(s => s.sessionhash == sessionHash) == null)
            {
                CreateNewSession(sessionHash, DateTime.Now.AddHours(3), sessionMitarbeiter, sessionKunde);
            }
            else if (data.session
                .FirstOrDefault(s => s.sessionhash == sessionHash) != null &&
                    data.session
                .FirstOrDefault(s => s.sessionhash == sessionHash).expires_at < DateTime.Now)
            {
                RemoveOldSession(sessionHash);
                CreateNewSession(sessionHash, DateTime.Now.AddHours(3), sessionMitarbeiter, sessionKunde);
            }

            if (this.Owner is Main_Form main)
            {
                main.Show();
            }
            this.Close();
        }
        private void CreateNewSession(string sessionHash, DateTime expireTime, mitarbeiter mitarbeiter, kunde kunde)
        {
            session newSession = new session
            {
                sessionhash = sessionHash,
                expires_at = expireTime,
                inserted_at = DateTime.Now,
                mitarbeiter = mitarbeiter,
                kunde = kunde
            };
            data.session.Add(newSession);
            data.SaveChanges();
        }

        private void RemoveOldSession(string sessionHash)
        {
            session session = data.session.Where(s => s.sessionhash == sessionHash).First();
            data.session.Remove(session);
            data.SaveChanges();
        }
    }


}
