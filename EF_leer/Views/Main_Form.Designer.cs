﻿
namespace EF_leer.Views
{
    partial class Main_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüsToolStripMenuItem,
            this.profileStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüsToolStripMenuItem
            // 
            this.menüsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechnungToolStripMenuItem,
            this.ticketToolStripMenuItem,
            this.neuErstellenToolStripMenuItem});
            this.menüsToolStripMenuItem.Name = "menüsToolStripMenuItem";
            this.menüsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.menüsToolStripMenuItem.Text = "Menü\'s";
            // 
            // rechnungToolStripMenuItem
            // 
            this.rechnungToolStripMenuItem.Name = "rechnungToolStripMenuItem";
            this.rechnungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rechnungToolStripMenuItem.Text = "Rechnung";
            this.rechnungToolStripMenuItem.Click += new System.EventHandler(this.rechnungToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ticketToolStripMenuItem.Text = "Ticket";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // profileStripMenuItem
            // 
            this.profileStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profileStripMenuItem.Name = "profileStripMenuItem";
            this.profileStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profileStripMenuItem.Text = "Profil";
            this.profileStripMenuItem.Click += new System.EventHandler(this.profileStripMenuItem_Click);
            // 
            // neuErstellenToolStripMenuItem
            // 
            this.neuErstellenToolStripMenuItem.Name = "neuErstellenToolStripMenuItem";
            this.neuErstellenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neuErstellenToolStripMenuItem.Text = "Neu erstellen";
            this.neuErstellenToolStripMenuItem.Click += new System.EventHandler(this.neuErstellenToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechnungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuErstellenToolStripMenuItem;
    }
}

