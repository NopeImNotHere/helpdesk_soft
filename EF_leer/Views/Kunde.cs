using AdysTech.CredentialManager;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class Kunde_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();
        public bool isLoggedOut = false;
        public Kunde_Form()
        {
            InitializeComponent();
            NetworkCredential credentials = CredentialManager.GetCredentials("sessionHash");
            string hash = credentials.Password;
            kunde mitarbeiter = data.session.Where(s => s.sessionhash == hash).First().kunde;
        }

        private void Return_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public Kunde_Form(kunde kunde)
        {
            InitializeComponent();

        }
    }
}
