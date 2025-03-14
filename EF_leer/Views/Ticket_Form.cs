using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EF_leer
{
    public partial class Ticket_Form : Form
    {
        oberstufe_db1Entities daten = new oberstufe_db1Entities();
        public Ticket_Form()
        {
            InitializeComponent();


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
        }

        private void Ticket_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                Erstelldatum = new DateTime()
            };
            daten.ticket.Add(Neu);
            daten.SaveChanges();
        }
    }
}
