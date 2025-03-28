
namespace EF_leer.Views
{
    partial class Erstellen
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
            System.Windows.Forms.Label beschreibungLabel;
            System.Windows.Forms.Label kostenLabel;
            System.Windows.Forms.Label hausnummerLabel;
            System.Windows.Forms.Label pLZLabel;
            System.Windows.Forms.Label stadtLabel;
            System.Windows.Forms.Label straßeLabel;
            System.Windows.Forms.Label beschreibungLabel1;
            System.Windows.Forms.Label farbeLabel;
            System.Windows.Forms.Label statusnameLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.beschreibungTextBox = new System.Windows.Forms.TextBox();
            this.kostenTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dienstleistungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hausnummerTextBox = new System.Windows.Forms.TextBox();
            this.pLZTextBox = new System.Windows.Forms.TextBox();
            this.stadtTextBox = new System.Windows.Forms.TextBox();
            this.straßeTextBox = new System.Windows.Forms.TextBox();
            this.Hinzufügen = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beschreibungTextBox1 = new System.Windows.Forms.TextBox();
            this.farbeTextBox = new System.Windows.Forms.TextBox();
            this.statusnameTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            beschreibungLabel = new System.Windows.Forms.Label();
            kostenLabel = new System.Windows.Forms.Label();
            hausnummerLabel = new System.Windows.Forms.Label();
            pLZLabel = new System.Windows.Forms.Label();
            stadtLabel = new System.Windows.Forms.Label();
            straßeLabel = new System.Windows.Forms.Label();
            beschreibungLabel1 = new System.Windows.Forms.Label();
            farbeLabel = new System.Windows.Forms.Label();
            statusnameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dienstleistungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(beschreibungLabel);
            this.tabPage1.Controls.Add(this.beschreibungTextBox);
            this.tabPage1.Controls.Add(kostenLabel);
            this.tabPage1.Controls.Add(this.kostenTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dienstleistungen erstellen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Hinzufügen);
            this.tabPage2.Controls.Add(hausnummerLabel);
            this.tabPage2.Controls.Add(this.hausnummerTextBox);
            this.tabPage2.Controls.Add(pLZLabel);
            this.tabPage2.Controls.Add(this.pLZTextBox);
            this.tabPage2.Controls.Add(stadtLabel);
            this.tabPage2.Controls.Add(this.stadtTextBox);
            this.tabPage2.Controls.Add(straßeLabel);
            this.tabPage2.Controls.Add(this.straßeTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kundenstandort erstellen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // beschreibungLabel
            // 
            beschreibungLabel.AutoSize = true;
            beschreibungLabel.Location = new System.Drawing.Point(18, 37);
            beschreibungLabel.Name = "beschreibungLabel";
            beschreibungLabel.Size = new System.Drawing.Size(75, 13);
            beschreibungLabel.TabIndex = 0;
            beschreibungLabel.Text = "Beschreibung:";
            // 
            // beschreibungTextBox
            // 
            this.beschreibungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dienstleistungBindingSource, "Beschreibung", true));
            this.beschreibungTextBox.Location = new System.Drawing.Point(117, 34);
            this.beschreibungTextBox.Name = "beschreibungTextBox";
            this.beschreibungTextBox.Size = new System.Drawing.Size(100, 20);
            this.beschreibungTextBox.TabIndex = 1;
            // 
            // kostenLabel
            // 
            kostenLabel.AutoSize = true;
            kostenLabel.Location = new System.Drawing.Point(18, 63);
            kostenLabel.Name = "kostenLabel";
            kostenLabel.Size = new System.Drawing.Size(43, 13);
            kostenLabel.TabIndex = 2;
            kostenLabel.Text = "Kosten:";
            // 
            // kostenTextBox
            // 
            this.kostenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dienstleistungBindingSource, "Kosten", true));
            this.kostenTextBox.Location = new System.Drawing.Point(117, 60);
            this.kostenTextBox.Name = "kostenTextBox";
            this.kostenTextBox.Size = new System.Drawing.Size(100, 20);
            this.kostenTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hinzufügen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dienstleistungBindingSource
            // 
            this.dienstleistungBindingSource.DataSource = typeof(EF_leer.dienstleistung);
            // 
            // ortBindingSource
            // 
            this.ortBindingSource.DataSource = typeof(EF_leer.ort);
            // 
            // hausnummerLabel
            // 
            hausnummerLabel.AutoSize = true;
            hausnummerLabel.Location = new System.Drawing.Point(36, 66);
            hausnummerLabel.Name = "hausnummerLabel";
            hausnummerLabel.Size = new System.Drawing.Size(72, 13);
            hausnummerLabel.TabIndex = 0;
            hausnummerLabel.Text = "Hausnummer:";
            // 
            // hausnummerTextBox
            // 
            this.hausnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ortBindingSource, "Hausnummer", true));
            this.hausnummerTextBox.Location = new System.Drawing.Point(114, 63);
            this.hausnummerTextBox.Name = "hausnummerTextBox";
            this.hausnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.hausnummerTextBox.TabIndex = 1;
            // 
            // pLZLabel
            // 
            pLZLabel.AutoSize = true;
            pLZLabel.Location = new System.Drawing.Point(36, 92);
            pLZLabel.Name = "pLZLabel";
            pLZLabel.Size = new System.Drawing.Size(30, 13);
            pLZLabel.TabIndex = 4;
            pLZLabel.Text = "PLZ:";
            // 
            // pLZTextBox
            // 
            this.pLZTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ortBindingSource, "PLZ", true));
            this.pLZTextBox.Location = new System.Drawing.Point(114, 89);
            this.pLZTextBox.Name = "pLZTextBox";
            this.pLZTextBox.Size = new System.Drawing.Size(100, 20);
            this.pLZTextBox.TabIndex = 5;
            // 
            // stadtLabel
            // 
            stadtLabel.AutoSize = true;
            stadtLabel.Location = new System.Drawing.Point(36, 118);
            stadtLabel.Name = "stadtLabel";
            stadtLabel.Size = new System.Drawing.Size(35, 13);
            stadtLabel.TabIndex = 6;
            stadtLabel.Text = "Stadt:";
            // 
            // stadtTextBox
            // 
            this.stadtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ortBindingSource, "Stadt", true));
            this.stadtTextBox.Location = new System.Drawing.Point(114, 115);
            this.stadtTextBox.Name = "stadtTextBox";
            this.stadtTextBox.Size = new System.Drawing.Size(100, 20);
            this.stadtTextBox.TabIndex = 7;
            // 
            // straßeLabel
            // 
            straßeLabel.AutoSize = true;
            straßeLabel.Location = new System.Drawing.Point(36, 144);
            straßeLabel.Name = "straßeLabel";
            straßeLabel.Size = new System.Drawing.Size(41, 13);
            straßeLabel.TabIndex = 8;
            straßeLabel.Text = "Straße:";
            // 
            // straßeTextBox
            // 
            this.straßeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ortBindingSource, "Straße", true));
            this.straßeTextBox.Location = new System.Drawing.Point(114, 141);
            this.straßeTextBox.Name = "straßeTextBox";
            this.straßeTextBox.Size = new System.Drawing.Size(100, 20);
            this.straßeTextBox.TabIndex = 9;
            // 
            // Hinzufügen
            // 
            this.Hinzufügen.Location = new System.Drawing.Point(39, 168);
            this.Hinzufügen.Name = "Hinzufügen";
            this.Hinzufügen.Size = new System.Drawing.Size(174, 23);
            this.Hinzufügen.TabIndex = 10;
            this.Hinzufügen.Text = "Hinzufügen";
            this.Hinzufügen.UseVisualStyleBackColor = true;
            this.Hinzufügen.Click += new System.EventHandler(this.Hinzufügen_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(beschreibungLabel1);
            this.tabPage3.Controls.Add(this.beschreibungTextBox1);
            this.tabPage3.Controls.Add(farbeLabel);
            this.tabPage3.Controls.Add(this.farbeTextBox);
            this.tabPage3.Controls.Add(statusnameLabel);
            this.tabPage3.Controls.Add(this.statusnameTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Status erstellen";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(EF_leer.status);
            // 
            // beschreibungLabel1
            // 
            beschreibungLabel1.AutoSize = true;
            beschreibungLabel1.Location = new System.Drawing.Point(35, 50);
            beschreibungLabel1.Name = "beschreibungLabel1";
            beschreibungLabel1.Size = new System.Drawing.Size(75, 13);
            beschreibungLabel1.TabIndex = 0;
            beschreibungLabel1.Text = "Beschreibung:";
            // 
            // beschreibungTextBox1
            // 
            this.beschreibungTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Beschreibung", true));
            this.beschreibungTextBox1.Location = new System.Drawing.Point(116, 47);
            this.beschreibungTextBox1.Name = "beschreibungTextBox1";
            this.beschreibungTextBox1.Size = new System.Drawing.Size(100, 20);
            this.beschreibungTextBox1.TabIndex = 1;
            // 
            // farbeLabel
            // 
            farbeLabel.AutoSize = true;
            farbeLabel.Location = new System.Drawing.Point(35, 76);
            farbeLabel.Name = "farbeLabel";
            farbeLabel.Size = new System.Drawing.Size(37, 13);
            farbeLabel.TabIndex = 2;
            farbeLabel.Text = "Farbe:";
            // 
            // farbeTextBox
            // 
            this.farbeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Farbe", true));
            this.farbeTextBox.Location = new System.Drawing.Point(116, 73);
            this.farbeTextBox.Name = "farbeTextBox";
            this.farbeTextBox.Size = new System.Drawing.Size(100, 20);
            this.farbeTextBox.TabIndex = 3;
            // 
            // statusnameLabel
            // 
            statusnameLabel.AutoSize = true;
            statusnameLabel.Location = new System.Drawing.Point(35, 24);
            statusnameLabel.Name = "statusnameLabel";
            statusnameLabel.Size = new System.Drawing.Size(66, 13);
            statusnameLabel.TabIndex = 6;
            statusnameLabel.Text = "Statusname:";
            // 
            // statusnameTextBox
            // 
            this.statusnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Statusname", true));
            this.statusnameTextBox.Location = new System.Drawing.Point(116, 21);
            this.statusnameTextBox.Name = "statusnameTextBox";
            this.statusnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusnameTextBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hinzufügen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Erstellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Erstellen";
            this.Text = "Erstellen";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dienstleistungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ortBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox beschreibungTextBox;
        private System.Windows.Forms.BindingSource dienstleistungBindingSource;
        private System.Windows.Forms.TextBox kostenTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Hinzufügen;
        private System.Windows.Forms.TextBox hausnummerTextBox;
        private System.Windows.Forms.BindingSource ortBindingSource;
        private System.Windows.Forms.TextBox pLZTextBox;
        private System.Windows.Forms.TextBox stadtTextBox;
        private System.Windows.Forms.TextBox straßeTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox beschreibungTextBox1;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.TextBox farbeTextBox;
        private System.Windows.Forms.TextBox statusnameTextBox;
    }
}