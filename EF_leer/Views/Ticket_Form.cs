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
                    Erstelldatum = DateTime.Now,
                    //mitarbeiter = session.mitarbeiter as mitarbeiter
            };
                daten.ticket.Add(Neu);

                daten.SaveChanges();

                ticket NeustTicket = daten.ticket.OrderByDescending(t => t.Erstelldatum).FirstOrDefault();
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
                    
                    try
                    {
                        daten.SaveChanges();
                    }
                    catch
                    {

                    }
                    this.Hide();
                    Ticket_Form newFormT = new Ticket_Form();
                    newFormT.Show();
                    this.Close();
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
                var dienstleistungen = daten.dienstleistung
                    .Join(daten.abgeleitet,
                        d => d.PK_Dienstleistung,
                        a => a.FK_Dienstleistung,
                        (d, a) => new { Dienstleistung = d, Abgeleitet = a })
                    .Where(x => x.Abgeleitet.FK_Ticket == ticketID)
                    .Select(x => x.Dienstleistung)
                    .ToList();

                dienstleistungBindingSource.DataSource = dienstleistungen;
            }
        }
    }
}
