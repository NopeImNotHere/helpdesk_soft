using System;
using System.Windows.Forms;

namespace EF_leer
{
    public partial class Main_Form : Form
    {
        public bool isLoggedIn = false;
        public Main_Form(string launchFormName)
        {
            InitializeComponent();
            windowLauncher(launchFormName);
        }

        public void windowLauncher(string formName)
        {
            Form form;
            switch (formName)
            {
                case "Login":
                    form = new Login_Form();
                    form.Owner = this;
                    form.ShowDialog();
                    break;
                case "Rechnung":
                    form = new Rechnung_Form();
                    ShowChildForm(form);
                    break;
                case "Ticket":
                    form = new Ticket_Form();
                    ShowChildForm(form);
                    break;
                case "Mitarbeiter":
                    form = new Mitarbeiter_Form();
                    ShowChildForm(form);
                    break;
                default:
                    break;
            }
        }
        private void ShowChildForm(Form childForm)
        {
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Show();

        }

        private void mitarbeiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            windowLauncher("Mitarbeiter");
        }

    }
}
