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
                if (Data.ticket.PK_Ticket == TicketId)
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
            int CurrentTicketId = CurrentRechnung.ticket.PK_Ticket;
            List<KeyValuePair<int,int>> DienstleistungIdUndAnzahl = new List<KeyValuePair<int,int>>();
            List<dienstleistung> Dienstleistungen = new List<dienstleistung>();
            foreach (abgeleitet abgeleitet in Datenbank.abgeleitet)
            {
                if (abgeleitet.FK_Ticket == CurrentTicketId)
                {
                    DienstleistungIdUndAnzahl.Add(new KeyValuePair<int,int>(abgeleitet.FK_Dienstleistung, (int)abgeleitet.Anzahl));
                }
            }
            foreach (dienstleistung Data in Datenbank.dienstleistung)
            {
                foreach(KeyValuePair<int,int> IdUndAnzahl in DienstleistungIdUndAnzahl)
                {
                    if(Data.PK_Dienstleistung == IdUndAnzahl.Key)
                    {
                        for(int i = 1; i <= IdUndAnzahl.Value; i++)
                        {
                            Dienstleistungen.Add(Data);
                        }
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
