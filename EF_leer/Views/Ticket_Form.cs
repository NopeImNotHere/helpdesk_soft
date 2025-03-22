using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdysTech.CredentialManager;
using System.Net;

namespace EF_leer.Views
{
    public partial class Ticket_Form : Form
    {
        oberstufe_db1Entities daten = new oberstufe_db1Entities();
        List<dienstleistung> ausgewählteDienstleistungen = new List<dienstleistung>();
        public Ticket_Form()
        {
            InitializeComponent();

            ticketBindingSource.DataSource = daten.ticket.ToList();


            List<kunde> Kunde = daten.kunde.ToList();
            comboBoxKunde.DataSource = Kunde;
            comboBoxKunde.DisplayMember = "Firmenname";
            comboBoxKunde.ValueMember = "PK_Kunde";

            List<art> Art = daten.art.ToList();
            comboBoxArt.DataSource = Art;
            comboBoxArt.DisplayMember = "Artname";
            comboBoxArt.ValueMember = "PK_Art";

            List<priorität> Priorität = daten.priorität.ToList();
            comboBoxPrio.DataSource = Priorität;
            comboBoxPrio.DisplayMember = "Prioritätsname";
            comboBoxPrio.ValueMember = "PK_Priorität";

            List<status> Status = daten.status.ToList();
            comboBoxStatus.DataSource = Status;
            comboBoxStatus.DisplayMember = "Statusname";
            comboBoxStatus.ValueMember = "PK_Status";

            List<dienstleistung> Dienstleistungen = daten.dienstleistung.ToList();
            comboBoxDienst.DataSource = Dienstleistungen;
            comboBoxDienst.DisplayMember = "Beschreibung";
            comboBoxDienst.ValueMember = "PK_Dienstleistung";


            listBox1.DisplayMember = "Beschreibung";

        }

        public Ticket_Form(ticket ticket) : this()
        {
            List<ticket> tickets = (List<ticket>)ticketBindingSource.DataSource;
            ticket bindingTicket = tickets.Where(t => t.PK_Ticket == ticket.PK_Ticket).First();
            int pos = tickets.IndexOf(bindingTicket);
            ticketBindingSource.Position = pos;
            tabControl1.SelectedIndex = 1;
        }

        private void Ticket_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*NetworkCredential creds = CredentialManager.GetCredentials("sessionHash");
            string sessionHash = creds.Password;
            session session = daten.session.Where(s => s.sessionhash == sessionHash).First();*/

            ticket Neu = new ticket
            {

                kunde = comboBoxKunde.SelectedItem as kunde,
                Ticket_Titel = textBoxTitel.Text,
                art = comboBoxArt.SelectedItem as art,
                priorität = comboBoxPrio.SelectedItem as priorität,
                status = comboBoxStatus.SelectedItem as status,
                Beschreibung = richTextBoxBesch.Text,
                InterneNotiz = richTextBoxIntNotiz.Text,
                InternerStatus = richTextBoxIntStatus.Text,
                Erstelldatum = DateTime.Now
                //mitarbeiter = session.mitarbeiter as mitarbeiter
            };
            daten.ticket.Add(Neu);

            if(daten.SaveChanges() != 0)
            {


            ticket NeustTicket = daten.ticket.Where(t => t.Erstelldatum == Neu.Erstelldatum).First();
            if (ausgewählteDienstleistungen != null && NeustTicket != null)
            {
                Dictionary<int, int> dienstleistungsZähler = new Dictionary<int, int>();

                foreach (var Dienst in ausgewählteDienstleistungen)
                {
                    if (!dienstleistungsZähler.ContainsKey(Dienst.PK_Dienstleistung))
                    {
                        dienstleistungsZähler[Dienst.PK_Dienstleistung] = 0;
                    }

                    dienstleistungsZähler[Dienst.PK_Dienstleistung]++;

                    abgeleitet abgel = new abgeleitet
                    {
                        FK_Dienstleistung = Dienst.PK_Dienstleistung,
                        FK_Ticket = NeustTicket.PK_Ticket,
                        Anzahl = dienstleistungsZähler[Dienst.PK_Dienstleistung]
                    };

                    daten.abgeleitet.Add(abgel);

                    daten.SaveChanges();
                    //this.Hide();
                    Ticket_Form newFormT = new Ticket_Form();
                    newFormT.Show();
                    this.Close();
                }
            }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxDienst.SelectedIndex != null)
            {
                ausgewählteDienstleistungen.Add(comboBoxDienst.SelectedItem as dienstleistung);
                string ausgDienstleistung = comboBoxDienst.Text;
                listBox1.Items.Add(ausgDienstleistung);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ticket aktTicket = ticketBindingSource.Current as ticket;
            int aktTicketID = aktTicket.PK_Ticket;

            Rechnung_Form FormRechnung = new Rechnung_Form(aktTicketID);
            FormRechnung.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var aktuellTicket = ticketBindingSource.Current as ticket;
            daten.SaveChanges();
            ticketBindingSource.ResetBindings(false);
        }

        private void ticketBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var aktTIcket = ticketBindingSource.Current as ticket;
            var ticketID = aktTIcket.PK_Ticket;
            using (var daten = new oberstufe_db1Entities())
            {
                List<KeyValuePair<int, int>> DienstleistungIdUndAnzahl = new List<KeyValuePair<int, int>>();
                List<dienstleistung> Dienstleistungen = new List<dienstleistung>();
                foreach (abgeleitet abgeleitet in daten.abgeleitet)
                {
                    if (abgeleitet.FK_Ticket == ticketID)
                    {
                        DienstleistungIdUndAnzahl.Add(new KeyValuePair<int, int>(abgeleitet.FK_Dienstleistung, (int)abgeleitet.Anzahl));
                    }
                }
                foreach (dienstleistung Data in daten.dienstleistung)
                {
                    foreach (KeyValuePair<int, int> IdUndAnzahl in DienstleistungIdUndAnzahl)
                    {
                        if (Data.PK_Dienstleistung == IdUndAnzahl.Key)
                        {
                            for (int i = 1; i <= IdUndAnzahl.Value; i++)
                            {
                                Dienstleistungen.Add(Data);
                            }
                        }
                    }
                }


                dienstleistungBindingSource.DataSource = Dienstleistungen;
            }


        }
    }
}
