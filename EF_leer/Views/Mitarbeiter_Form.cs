using AdysTech.CredentialManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class Mitarbeiter_Form : Form
    {
        private mitarbeiter currentMitarbeiter;
        private static readonly Random _rand = new Random();
        private oberstufe_db1Entities data = new oberstufe_db1Entities();
        private string currentHint = "";
        public bool isLoggedOut = false;
        
        public Mitarbeiter_Form()
        {
            NetworkCredential credentials = CredentialManager.GetCredentials("sessionHash");
            if (credentials == null)
            {
                OpenErrorScreen();
                return;
            }
            InitializeComponent();
            string hash = credentials.Password;
            mitarbeiter mitarbeiter = data.session.Where(s => s.sessionhash == hash).First().mitarbeiter;
            LoadData(mitarbeiter);

            List<ort> orte = data.ort.ToList();
            AutoCompleteStringCollection orteCollection = new AutoCompleteStringCollection();
            orteCollection.AddRange(orte.Select(o => o.Stadt).ToArray());
            orteCollection.AddRange(orte.Select(o => o.PLZ).ToArray());
            ticketUeberKundenOrt.AutoCompleteCustomSource = orteCollection;

            int count = orte.Count;
            string randomStadt = orteCollection[_rand.Next(0, count)];
            string randomPLZ = orteCollection[_rand.Next(count, count * 2)];
            currentHint = $"{randomStadt} oder {randomPLZ}";
            ticketUeberKundenOrt.Text = currentHint;
            ticketUeberKundenOrt.ForeColor = Color.Gray;

        }


        public Mitarbeiter_Form(mitarbeiter mitarbeiter)
        {
            InitializeComponent();
            LoadData(mitarbeiter);
        }

        public void LoadData(mitarbeiter mitarbeiter)
        {
            ticketBindingSource.DataSource = mitarbeiter.ticket;
            List<rechnung> rechnungen = mitarbeiter.ticket.SelectMany(t => t.rechnung).ToList();
            rechnungBindingSource.DataSource = rechnungen;
            currentMitarbeiter = mitarbeiter;
        }

        private void OpenErrorScreen()
        {
            this.ClientSize = new Size(800, 400);
            this.Text = "Centered Elements";

            Label Warning = new Label();
            Warning.Text = "Im Debug mode wenn sie sich nicht angemeldet haben über Login einmal haben Sie keine Anmeldedaten";
            Warning.Font = new Font(Warning.Font.FontFamily, 20, FontStyle.Bold);
            Warning.Size = new Size(700, 100);
            Warning.TextAlign = ContentAlignment.MiddleCenter;
            Warning.AutoSize = false;

            System.Windows.Forms.Button Return = new System.Windows.Forms.Button();
            Return.Text = "Zurückkehren";
            Return.Font = new Font(Return.Font.FontFamily, 16, FontStyle.Bold);
            Return.Click += Return_Click;
            Return.Size = new Size(200, 50);

            Warning.Location = new Point((this.ClientSize.Width - Warning.Width) / 2, (this.ClientSize.Height / 2) - 100);
            Return.Location = new Point((this.ClientSize.Width - Return.Width) / 2, (this.ClientSize.Height / 2) + 20);

            this.Controls.Add(Warning);
            this.Controls.Add(Return);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CredentialManager.RemoveCredentials("sessionHash");
            isLoggedOut = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is Main_Form form)
            {
                this.Close();
                form.windowLauncher(new Ticket_Form(), false);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is Main_Form form)
            {
                this.Close();
                form.windowLauncher(new Rechnung_Form(), false);
            }
        }

        private void ticketDataGridView_Click(object sender, EventArgs e)
        {
            ticket ClickedTicket = (ticket)ticketBindingSource.Current;
            if (ClickedTicket.rechnung != null)
            {
                List<rechnung> rechnungen = rechnungBindingSource.DataSource as List<rechnung>;
                int rowIndex = 0;
                for (int i = 0; i < rechnungen.Count; i++)
                {
                    if (rechnungen[i].Rechnungsnr == ClickedTicket.rechnung.First().Rechnungsnr)
                    {
                        rowIndex = i;
                        break;
                    }
                }
                rechnungDataGridView.ClearSelection();
                if (rowIndex >= 0)
                {
                    rechnungDataGridView.Rows[rowIndex].Selected = true;
                }
            }
        }

        private void ticketUeberKundenOrt_TextChanged(object sender, EventArgs e)
        {
            string searchOrt = ticketUeberKundenOrt.Text;
            if(searchOrt == string.Empty || searchOrt == currentHint)
            {
                return;
            }
            ort dataOrt = new ort();
            foreach(ort ort in data.ort.ToList())
            {
                if(ort.Stadt.Contains(searchOrt) || ort.PLZ.Contains(searchOrt))
                {
                    dataOrt = ort;
                }
            }

            kunde dataKunde = new kunde();
            foreach(kunde kunde in data.kunde.ToList())
            {
                if(kunde.ort.Contains(dataOrt))
                {
                    dataKunde = kunde;
                }
            }

            List<ticket> filteredTickets = new List<ticket>();
            foreach(ticket ticket in dataKunde.ticket.ToList())
            {
                if(ticket.mitarbeiter == currentMitarbeiter)
                {
                    filteredTickets.Add(ticket);
                }
            }

            ticketBindingSource.DataSource = filteredTickets;
        }

        private void ticketUeberKundenOrt_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ticketUeberKundenOrt.Text))
            {
                ticketUeberKundenOrt.Text = currentHint;
                ticketUeberKundenOrt.ForeColor = Color.Gray;
                ticketBindingSource.DataSource = currentMitarbeiter.ticket;
            }
        }

        private void ticketUeberKundenOrt_Enter(object sender, System.EventArgs e)
        {
            if (ticketUeberKundenOrt.Text == currentHint)
            {
                ticketUeberKundenOrt.Text = "";
                ticketUeberKundenOrt.ForeColor = Color.Black;
            }
        }

        private void rechnungDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rechnung rechnung = rechnungBindingSource.Current as rechnung;
            if(this.MdiParent != null && this.MdiParent is Main_Form)
            {
                (this.MdiParent as Main_Form).windowLauncher(new Rechnung_Form(rechnung.ticket.PK_Ticket), false);
                this.Close();
            }
        }

        private void ticketDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ticket ticket = ticketBindingSource.Current as ticket;
            if (this.MdiParent != null && this.MdiParent is Main_Form)
            {
                (this.MdiParent as Main_Form).windowLauncher(new Ticket_Form(ticket), false);
                this.Close();
            }
        }
    }
}
