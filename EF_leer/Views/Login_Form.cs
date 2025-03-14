using EF_leer.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using AdysTech.CredentialManager;

namespace EF_leer
{
    public partial class Login_Form : Form
    {
        oberstufe_db1Entities1 data = new oberstufe_db1Entities1();
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
            string hashed_password = LoginHelper.hashPassword(Password_Field.Text);
            dynamic match = null;

            match = data.mitarbeiter.FirstOrDefault(mitarbeiter => mitarbeiter.Email.Equals(email) && mitarbeiter.Passwort.Equals(hashed_password));
            if (match != null)
            {

            }

            match = data.kunde.FirstOrDefault(kunde => kunde.Email.Equals(email) && kunde.Passwort.Equals(hashed_password));
            if (match != null)
            {

            }
        }
    }
}
