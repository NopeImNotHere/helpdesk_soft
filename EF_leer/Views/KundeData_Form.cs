using EF_leer.util;
using System.Linq;
using System.Windows.Forms;

namespace EF_leer.Views
{
    public partial class KundeData_Form : Form
    {
        oberstufe_db1Entities data = new oberstufe_db1Entities();
        public KundeData_Form(kunde kunde)
        {
            InitializeComponent();
            kundeBindingSource.DataSource = kunde;

            ortBox.DataSource = data.ort.ToList();
            ortBox.DisplayMember = $"PLZ";
        }

        private void saveChanges_Click(object sender, System.EventArgs e)
        {
            kunde updated = (kunde)kundeBindingSource.Current;
            kunde kunde = data.kunde.SingleOrDefault(k => k.PK_Kunde == updated.PK_Kunde);
            if (kunde.Passwort != updated.Passwort)
            {
                kunde.Passwort = LoginHelper.HashPassword(kunde.Passwort);
            }
            kunde = updated;
            kundeBindingSource.ResetBindings(false);
            data.SaveChanges();
        }
    }
}
