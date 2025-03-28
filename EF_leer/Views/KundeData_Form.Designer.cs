
namespace EF_leer.Views
{
    partial class KundeData_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label firmennameLabel;
            System.Windows.Forms.Label kundennummerLabel;
            System.Windows.Forms.Label passwortLabel;
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.firmennameTextBox = new System.Windows.Forms.TextBox();
            this.kundennummerTextBox = new System.Windows.Forms.TextBox();
            this.passwortTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ortBox = new System.Windows.Forms.ComboBox();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            emailLabel = new System.Windows.Forms.Label();
            firmennameLabel = new System.Windows.Forms.Label();
            kundennummerLabel = new System.Windows.Forms.Label();
            passwortLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            emailLabel.Location = new System.Drawing.Point(0, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(296, 17);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firmennameLabel
            // 
            firmennameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            firmennameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            firmennameLabel.Location = new System.Drawing.Point(0, 37);
            firmennameLabel.Name = "firmennameLabel";
            firmennameLabel.Size = new System.Drawing.Size(296, 17);
            firmennameLabel.TabIndex = 3;
            firmennameLabel.Text = "Firmenname:";
            firmennameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kundennummerLabel
            // 
            kundennummerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            kundennummerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            kundennummerLabel.Location = new System.Drawing.Point(0, 74);
            kundennummerLabel.Name = "kundennummerLabel";
            kundennummerLabel.Size = new System.Drawing.Size(296, 22);
            kundennummerLabel.TabIndex = 5;
            kundennummerLabel.Text = "Kundennummer:";
            kundennummerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwortLabel
            // 
            passwortLabel.Dock = System.Windows.Forms.DockStyle.Top;
            passwortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            passwortLabel.Location = new System.Drawing.Point(0, 116);
            passwortLabel.Name = "passwortLabel";
            passwortLabel.Size = new System.Drawing.Size(296, 18);
            passwortLabel.TabIndex = 7;
            passwortLabel.Text = "Passwort:";
            passwortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataSource = typeof(EF_leer.kunde);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "Email", true));
            this.emailTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailTextBox.Location = new System.Drawing.Point(0, 17);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(296, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // firmennameTextBox
            // 
            this.firmennameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "Firmenname", true));
            this.firmennameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.firmennameTextBox.Location = new System.Drawing.Point(0, 54);
            this.firmennameTextBox.Name = "firmennameTextBox";
            this.firmennameTextBox.Size = new System.Drawing.Size(296, 20);
            this.firmennameTextBox.TabIndex = 4;
            // 
            // kundennummerTextBox
            // 
            this.kundennummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "Kundennummer", true));
            this.kundennummerTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.kundennummerTextBox.Location = new System.Drawing.Point(0, 96);
            this.kundennummerTextBox.Name = "kundennummerTextBox";
            this.kundennummerTextBox.Size = new System.Drawing.Size(296, 20);
            this.kundennummerTextBox.TabIndex = 6;
            // 
            // passwortTextBox
            // 
            this.passwortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "Passwort", true));
            this.passwortTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwortTextBox.Location = new System.Drawing.Point(0, 134);
            this.passwortTextBox.Name = "passwortTextBox";
            this.passwortTextBox.Size = new System.Drawing.Size(296, 20);
            this.passwortTextBox.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ortBox);
            this.panel1.Controls.Add(this.cancelChanges);
            this.panel1.Controls.Add(this.saveChanges);
            this.panel1.Controls.Add(this.passwortTextBox);
            this.panel1.Controls.Add(passwortLabel);
            this.panel1.Controls.Add(this.kundennummerTextBox);
            this.panel1.Controls.Add(kundennummerLabel);
            this.panel1.Controls.Add(this.firmennameTextBox);
            this.panel1.Controls.Add(firmennameLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 202);
            this.panel1.TabIndex = 12;
            // 
            // ortBox
            // 
            this.ortBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortBox.FormattingEnabled = true;
            this.ortBox.Location = new System.Drawing.Point(75, 154);
            this.ortBox.Name = "ortBox";
            this.ortBox.Size = new System.Drawing.Size(146, 21);
            this.ortBox.TabIndex = 13;
            // 
            // cancelChanges
            // 
            this.cancelChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelChanges.Location = new System.Drawing.Point(221, 154);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(75, 48);
            this.cancelChanges.TabIndex = 10;
            this.cancelChanges.Text = "Abbrechen";
            this.cancelChanges.UseVisualStyleBackColor = true;
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveChanges.Location = new System.Drawing.Point(0, 154);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(75, 48);
            this.saveChanges.TabIndex = 9;
            this.saveChanges.Text = "Speichern";
            this.saveChanges.UseVisualStyleBackColor = true;
            // 
            // KundeData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 229);
            this.Controls.Add(this.panel1);
            this.Name = "KundeData_Form";
            this.Text = "Daten Ändern";
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource kundeBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox firmennameTextBox;
        private System.Windows.Forms.TextBox kundennummerTextBox;
        private System.Windows.Forms.TextBox passwortTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.ComboBox ortBox;
    }
}