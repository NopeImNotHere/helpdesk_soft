using AdysTech.CredentialManager;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class Mitarbeiter_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();
        public bool isLoggedOut = false;
        public Mitarbeiter_Form()
        {
            NetworkCredential credentials = CredentialManager.GetCredentials("sessionHash");
            if (credentials == null)
            {
                this.ClientSize = new Size(800, 400);
                this.Text = "Centered Elements";

                Label Warning = new Label();
                Warning.Text = "Im Debug mode wenn sie sich nicht angemeldet haben über Login einmal haben Sie keine Anmeldedaten";
                Warning.Font = new Font(Warning.Font.FontFamily, 20, FontStyle.Bold);
                Warning.Size = new Size(700, 100);
                Warning.TextAlign = ContentAlignment.MiddleCenter;
                Warning.AutoSize = false;

                Button Return = new Button();
                Return.Text = "Zurückkehren";
                Return.Font = new Font(Return.Font.FontFamily, 16, FontStyle.Bold);
                Return.Click += Return_Click;
                Return.Size = new Size(200, 50);

                Warning.Location = new Point((this.ClientSize.Width - Warning.Width) / 2, (this.ClientSize.Height / 2) - 100);
                Return.Location = new Point((this.ClientSize.Width - Return.Width) / 2, (this.ClientSize.Height / 2) + 20);

                this.Controls.Add(Warning);
                this.Controls.Add(Return);

                return;
            }
            InitializeComponent();
            string hash = credentials.Password;
            mitarbeiter mitarbeiter = data.session.Where(s => s.sessionhash == hash).First().mitarbeiter;
            LoadData(mitarbeiter);
        }

        private void Return_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public Mitarbeiter_Form(mitarbeiter mitarbeiter)
        {
            InitializeComponent();
            LoadData(mitarbeiter);
        }

        public void LoadData(mitarbeiter mitarbeiter)
        {
            ticketBindingSource.DataSource = mitarbeiter.ticket;
            rechnungBindingSource.DataSource = mitarbeiter.ticket.Where(t => t.rechnung != null).Select(t => t.rechnung).ToList();
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            CredentialManager.RemoveCredentials("sessionHash");
            isLoggedOut = true;
            this.Close();
        }
    }
}
