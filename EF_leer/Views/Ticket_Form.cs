using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_leer
{
    public partial class Ticket_Form : Form
    {
        public Ticket_Form()
        {
            InitializeComponent();
            
        }

        private void Ticket_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Kunde = comboBoxKunde.SelectedIndex;
            string Titel = textBoxTitel.Text;
            int Art = comboBoxArt.SelectedIndex;
            int Prio = comboBoxPrio.SelectedIndex;
            int Status = comboBoxStatus.SelectedIndex;
            string Beschreibung = richTextBoxBesch.Text;
            string IntNotiz = richTextBoxIntNotiz.Text;
            string IntStatus = richTextBoxIntStatus.Text;
            DateTime Erstelldatum = new DateTime();
        }
    }
}
