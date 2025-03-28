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
            NetworkCredential creds = CredentialManager.GetCredentials("sessionHash");
            string sessionHash = creds.Password;
            session session = daten.session.Where(s => s.sessionhash == sessionHash).First();
            ticket Neu = new ticket();

            if (session.mitarbeiter != null)
            {
                Neu.kunde = comboBoxKunde.SelectedItem as kunde;
                Neu.Ticket_Titel = textBoxTitel.Text;
                Neu.art = comboBoxArt.SelectedItem as art;
                Neu.priorität = comboBoxPrio.SelectedItem as priorität;
                Neu.status = comboBoxStatus.SelectedItem as status;
                Neu.Beschreibung = richTextBoxBesch.Text;
                Neu.InterneNotiz = richTextBoxIntNotiz.Text;
                Neu.InternerStatus = richTextBoxIntStatus.Text;
                Neu.Erstelldatum = DateTime.Now;
                Neu.mitarbeiter = session.mitarbeiter as mitarbeiter;

                daten.ticket.Add(Neu);
            }
            else
            {
                Neu.kunde = comboBoxKunde.SelectedItem as kunde;
                Neu.Ticket_Titel = textBoxTitel.Text;
                Neu.art = comboBoxArt.SelectedItem as art;
                Neu.priorität = comboBoxPrio.SelectedItem as priorität;
                Neu.status = comboBoxStatus.SelectedItem as status;
                Neu.Beschreibung = richTextBoxBesch.Text;
                Neu.InterneNotiz = richTextBoxIntNotiz.Text;
                Neu.InternerStatus = richTextBoxIntStatus.Text;
                Neu.Erstelldatum = DateTime.Now;

                daten.ticket.Add(Neu);
            }

            if(daten.SaveChanges() != 0)
            {


                //ticket NeustTicket = daten.ticket.Where(t => t.Erstelldatum == Neu.Erstelldatum).First();
                ticket NeustTicket = Neu;
                var PKT = NeustTicket.PK_Ticket;
            if (ausgewählteDienstleistungen != null && NeustTicket != null)
            {

                    foreach (var gruppe in ausgewählteDienstleistungen.GroupBy(d => d.PK_Dienstleistung))
                    {
                        var Anzahl = gruppe.Count();

                        abgeleitet abgel = new abgeleitet
                        {
                            Anzahl = Anzahl,
                            FK_Dienstleistung = gruppe.Key,
                            FK_Ticket = NeustTicket.PK_Ticket
                        };
                        daten.abgeleitet.Add(abgel);
                    }

                    daten.SaveChanges();
                    //this.Hide();
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

            aktuellTicket.Bearbeitungsdatum = DateTime.Now;
            
            var ausgewählteArt = comboArt.SelectedItem as art;
            var ausgewähltePrio = comboPrio.SelectedItem as priorität;
            var ausgewählterStatus = comboStatus.SelectedItem as status;

            if (ausgewählteArt != null)
                aktuellTicket.art = daten.art.Find(ausgewählteArt.PK_Art);

            if (ausgewähltePrio != null)
                aktuellTicket.priorität = daten.priorität.Find(ausgewähltePrio.PK_Priorität);

            if (ausgewählterStatus != null)
                aktuellTicket.status = daten.status.Find(ausgewählterStatus.PK_Status);

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
                comboArt.DataSource = daten.art.ToList();
                comboArt.DisplayMember = "Artname";
                comboArt.ValueMember = "PK_Art";
                foreach (var item in comboArt.Items)
                {
                    var Item = item as art;
                    if (Item.Artname.ToString() == aktTIcket.art.Artname.ToString())
                    {
                        comboArt.SelectedItem = item;
                    }
                }

                comboPrio.DataSource = daten.priorität.ToList();
                comboPrio.DisplayMember = "Prioritätsname";
                comboPrio.ValueMember = "PK_Priorität";
                foreach (var item in comboPrio.Items)
                {
                    var Item = item as priorität;
                    if (Item.Prioritätsname.ToString() == aktTIcket.priorität.Prioritätsname.ToString())
                    {
                        comboPrio.SelectedItem = item;
                    }
                }

                comboStatus.DataSource = daten.status.ToList();
                comboStatus.DisplayMember = "Statusname";
                comboStatus.ValueMember = "PK_Status";
                foreach (var item in comboStatus.Items)
                {
                    var Item = item as status;
                    if (Item.Statusname.ToString() == aktTIcket.status.Statusname.ToString())
                    {
                        comboStatus.SelectedItem = item;
                    }
                }

                dienstleistungBindingSource.DataSource = Dienstleistungen;
            }


        }
    }
}
