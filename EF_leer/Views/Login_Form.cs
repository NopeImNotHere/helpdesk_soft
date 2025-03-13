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
using System.Windows.Forms;

namespace EF_leer
{
    public partial class Login_Form : Form
    {
        oberstufe_db1Entities1 data = new oberstufe_db1Entities1 ();
        public Login_Form()
        {
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(this.Owner != null && (this.Owner as Main_Form).isLoggedIn) { 
                base.OnFormClosing(e);
            } else
            {
                e.Cancel = true;
            }
        }
        private void Login_Click(object sender, EventArgs e)
        {
            string email = EMail_Field.Text;
            string hashed_password = PasswordHelper.hashPassword(Password_Field.Text);
            
            if (data.mitarbeiter.Any(mitarbeiter => mitarbeiter.Email == email) && data.mitarbeiter.Any(mitarbeiter => mitarbeiter.Passwort == hashed_password))
            {
                (this.Owner as Main_Form).isLoggedIn = true;
                this.Close();
            }
        }
    }
}
