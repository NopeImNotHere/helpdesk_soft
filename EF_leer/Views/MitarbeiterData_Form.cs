using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class MitarbeiterData_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();
        mitarbeiter currentMitarbeiter = new mitarbeiter();
        public MitarbeiterData_Form(mitarbeiter mitarbeiter)
        {
            InitializeComponent();
            mitarbeiterBindingSource.DataSource = mitarbeiter;
            currentMitarbeiter = mitarbeiter;

            ortBox.DataSource = data.ort.ToList();
            ortBox.DisplayMember = $"PLZ";
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            mitarbeiter mitarbeiter = data.mitarbeiter.SingleOrDefault(m => m.PK_Mitarbeiter == currentMitarbeiter.PK_Mitarbeiter);
            mitarbeiter = currentMitarbeiter;
            data.SaveChanges();
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
