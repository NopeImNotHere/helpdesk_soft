
namespace EF_leer.Views
{
    partial class MitarbeiterData_Form
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
            System.Windows.Forms.Label festnetznummerLabel;
            System.Windows.Forms.Label mobilnummerLabel;
            System.Windows.Forms.Label nachnameLabel;
            System.Windows.Forms.Label passwortLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label vornameLabel;
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.festnetznummerTextBox = new System.Windows.Forms.TextBox();
            this.mobilnummerTextBox = new System.Windows.Forms.TextBox();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.passwortTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ortBox = new System.Windows.Forms.ComboBox();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            emailLabel = new System.Windows.Forms.Label();
            festnetznummerLabel = new System.Windows.Forms.Label();
            mobilnummerLabel = new System.Windows.Forms.Label();
            nachnameLabel = new System.Windows.Forms.Label();
            passwortLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.Dock = System.Windows.Forms.DockStyle.Top;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            emailLabel.Location = new System.Drawing.Point(0, 77);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(288, 18);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email:";
            emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // festnetznummerLabel
            // 
            festnetznummerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            festnetznummerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            festnetznummerLabel.Location = new System.Drawing.Point(0, 154);
            festnetznummerLabel.Name = "festnetznummerLabel";
            festnetznummerLabel.Size = new System.Drawing.Size(288, 21);
            festnetznummerLabel.TabIndex = 3;
            festnetznummerLabel.Text = "Festnetznummer:";
            festnetznummerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mobilnummerLabel
            // 
            mobilnummerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            mobilnummerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            mobilnummerLabel.Location = new System.Drawing.Point(0, 195);
            mobilnummerLabel.Name = "mobilnummerLabel";
            mobilnummerLabel.Size = new System.Drawing.Size(288, 18);
            mobilnummerLabel.TabIndex = 5;
            mobilnummerLabel.Text = "Mobilnummer:";
            mobilnummerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nachnameLabel
            // 
            nachnameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nachnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            nachnameLabel.Location = new System.Drawing.Point(0, 37);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new System.Drawing.Size(288, 20);
            nachnameLabel.TabIndex = 7;
            nachnameLabel.Text = "Nachname:";
            nachnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwortLabel
            // 
            passwortLabel.Dock = System.Windows.Forms.DockStyle.Top;
            passwortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            passwortLabel.Location = new System.Drawing.Point(0, 115);
            passwortLabel.Name = "passwortLabel";
            passwortLabel.Size = new System.Drawing.Size(288, 19);
            passwortLabel.TabIndex = 9;
            passwortLabel.Text = "Passwort:";
            passwortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // positionLabel
            // 
            positionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            positionLabel.Location = new System.Drawing.Point(0, 233);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(288, 17);
            positionLabel.TabIndex = 13;
            positionLabel.Text = "Position:";
            positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vornameLabel
            // 
            vornameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            vornameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            vornameLabel.Location = new System.Drawing.Point(0, 0);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(288, 17);
            vornameLabel.TabIndex = 15;
            vornameLabel.Text = "Vorname:";
            vornameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitarbeiterBindingSource, "Email", true));
            this.emailTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.emailTextBox.Location = new System.Drawing.Point(0, 95);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(288, 20);
            this.emailTextBox.TabIndex = 2;
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataSource = typeof(EF_leer.mitarbeiter);
            // 
            // festnetznummerTextBox
            // 
            this.festnetznummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitarbeiterBindingSource, "Festnetznummer", true));
            this.festnetznummerTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.festnetznummerTextBox.Location = new System.Drawing.Point(0, 175);
            this.festnetznummerTextBox.Name = "festnetznummerTextBox";
            this.festnetznummerTextBox.Size = new System.Drawing.Size(288, 20);
            this.festnetznummerTextBox.TabIndex = 4;
            // 
            // mobilnummerTextBox
            // 
            this.mobilnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitarbeiterBindingSource, "Mobilnummer", true));
            this.mobilnummerTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mobilnummerTextBox.Location = new System.Drawing.Point(0, 213);
            this.mobilnummerTextBox.Name = "mobilnummerTextBox";
            this.mobilnummerTextBox.Size = new System.Drawing.Size(288, 20);
            this.mobilnummerTextBox.TabIndex = 6;
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitarbeiterBindingSource, "Nachname", true));
            this.nachnameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nachnameTextBox.Location = new System.Drawing.Point(0, 57);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(288, 20);
            this.nachnameTextBox.TabIndex = 8;
            // 
            // passwortTextBox
            // 
            this.passwortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitarbeiterBindingSource, "Passwort", true));
            this.passwortTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwortTextBox.Location = new System.Drawing.Point(0, 134);
            this.passwortTextBox.Name = "passwortTextBox";
            this.passwortTextBox.Size = new System.Drawing.Size(288, 20);
            this.passwortTextBox.TabIndex = 10;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitarbeiterBindingSource, "Position", true));
            this.positionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.positionTextBox.Location = new System.Drawing.Point(0, 250);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(288, 20);
            this.positionTextBox.TabIndex = 14;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mitarbeiterBindingSource, "Vorname", true));
            this.vornameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.vornameTextBox.Location = new System.Drawing.Point(0, 17);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(288, 20);
            this.vornameTextBox.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ortBox);
            this.panel1.Controls.Add(this.cancelChanges);
            this.panel1.Controls.Add(this.saveChanges);
            this.panel1.Controls.Add(this.positionTextBox);
            this.panel1.Controls.Add(positionLabel);
            this.panel1.Controls.Add(this.mobilnummerTextBox);
            this.panel1.Controls.Add(mobilnummerLabel);
            this.panel1.Controls.Add(this.festnetznummerTextBox);
            this.panel1.Controls.Add(festnetznummerLabel);
            this.panel1.Controls.Add(this.passwortTextBox);
            this.panel1.Controls.Add(passwortLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.nachnameTextBox);
            this.panel1.Controls.Add(nachnameLabel);
            this.panel1.Controls.Add(this.vornameTextBox);
            this.panel1.Controls.Add(vornameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 293);
            this.panel1.TabIndex = 17;
            // 
            // ortBox
            // 
            this.ortBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.mitarbeiterBindingSource, "ort", true));
            this.ortBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mitarbeiterBindingSource, "ort", true));
            this.ortBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ortBox.FormattingEnabled = true;
            this.ortBox.Location = new System.Drawing.Point(75, 270);
            this.ortBox.Name = "ortBox";
            this.ortBox.Size = new System.Drawing.Size(138, 21);
            this.ortBox.TabIndex = 19;
            // 
            // cancelChanges
            // 
            this.cancelChanges.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancelChanges.Location = new System.Drawing.Point(213, 270);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(75, 23);
            this.cancelChanges.TabIndex = 18;
            this.cancelChanges.Text = "Abbrechen";
            this.cancelChanges.UseVisualStyleBackColor = true;
            this.cancelChanges.Click += new System.EventHandler(this.cancelChanges_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Dock = System.Windows.Forms.DockStyle.Left;
            this.saveChanges.Location = new System.Drawing.Point(0, 270);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(75, 23);
            this.saveChanges.TabIndex = 17;
            this.saveChanges.Text = "Speichern";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // MitarbeiterData_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 316);
            this.Controls.Add(this.panel1);
            this.Name = "MitarbeiterData_Form";
            this.Text = "Daten ändern";
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox festnetznummerTextBox;
        private System.Windows.Forms.TextBox mobilnummerTextBox;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.TextBox passwortTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ortBox;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.Button saveChanges;
    }
}