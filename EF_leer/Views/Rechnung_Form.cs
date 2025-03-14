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
    public partial class Rechnung_Form : Form
    {
        oberstufe_db1Entities Datenbank = new oberstufe_db1Entities();
        public Rechnung_Form()
        {
            InitializeComponent();
            rechnungBindingSource.DataSource = Datenbank.rechnung.ToList();
            abgeleitetBindingSource.DataSource = Datenbank.abgeleitet.ToList();

            foreach(var Data in Datenbank.rechnung)
            {
                IsInstallmentPaymentApproved(Data.Ratenzahlung != null);
            }
        }

        public void IsInstallmentPaymentApproved(bool Value)
        {
            if(Value)
            {
                ratenzahlungCheckBox.Checked = true;
            }
            else
            {
                ratenzahlungCheckBox.Checked = false;
            }
        }

        private void ratenzahlungCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            ratenzahlungCheckBox.Checked = !ratenzahlungCheckBox.Checked;
        }
    }
}
