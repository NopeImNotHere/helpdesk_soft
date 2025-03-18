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

            foreach (var Data in Datenbank.rechnung)
            {
                IsInstallmentPaymentApproved(Data.Ratenzahlung != null);
            }
        }

        public Rechnung_Form(int TicketId)
        {
            InitializeComponent();

            foreach (var Data in Datenbank.rechnung)
            {
                if (Data.ticket.PK_Ticket/*?????????*/ == TicketId)
                {
                    rechnungBindingSource.DataSource = Data;
                }
            }

            foreach (var Data in Datenbank.rechnung)
            {
                IsInstallmentPaymentApproved(Data.Ratenzahlung != null);
            }
        }

        public void IsInstallmentPaymentApproved(bool Value)
        {
            if (Value)
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

        private void rechnungBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            rechnung CurrentRechnung = rechnungBindingSource.Current as rechnung;
            int CurrentTicketId = Convert.ToInt32(CurrentRechnung.ticket.PK_Ticket/*???????*/);
            List<int> DienstleistungId = new List<int>();
            List<dienstleistung> Dienstleistungen = new List<dienstleistung>();
            foreach (var Data in Datenbank.abgeleitet)
            {
                if (Data.FK_Ticket == CurrentTicketId)
                {
                    DienstleistungId.Add(Data.FK_Dienstleistung);
                }
            }
            foreach (var Data in Datenbank.dienstleistung)
            {
                foreach (var Bata in DienstleistungId)
                {
                    if (Data.PK_Dienstleistung == Bata)
                    {
                        Dienstleistungen.Add(Data);
                    }
                }
            }
            foreach (var Data in Datenbank.ticket)
            {
                if (CurrentTicketId == Data.PK_Ticket)
                {
                    ticketBindingSource.DataSource = Data;
                }
            }

            dienstleistungBindingSource.DataSource = Dienstleistungen;
        }
    }
}
