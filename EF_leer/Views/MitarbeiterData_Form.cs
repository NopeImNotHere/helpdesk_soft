using EF_leer.util;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class MitarbeiterData_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();
        public MitarbeiterData_Form(mitarbeiter mitarbeiter)
        {
            InitializeComponent();
            mitarbeiterBindingSource.DataSource = mitarbeiter;

            ortBox.DataSource = data.ort.ToList();
            ortBox.DisplayMember = $"PLZ";
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            mitarbeiter updated = (mitarbeiter)mitarbeiterBindingSource.Current;
            mitarbeiter mitarbeiter = data.mitarbeiter.SingleOrDefault(m => m.PK_Mitarbeiter == updated.PK_Mitarbeiter);
            if (mitarbeiter.Passwort != updated.Passwort)
            {
                mitarbeiter.Passwort = LoginHelper.HashPassword(mitarbeiter.Passwort);
            }
            mitarbeiter = updated;
            mitarbeiterBindingSource.ResetBindings(false);
            data.SaveChanges();
        }

        private void cancelChanges_Click(object sender, EventArgs e)
        {
            mitarbeiterBindingSource.Clear();
            this.Close();
        }
    }
}
