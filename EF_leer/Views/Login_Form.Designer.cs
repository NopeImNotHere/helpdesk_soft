
namespace EF_leer.Views
{
    partial class Login_Form
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
            this.Login_BTN = new System.Windows.Forms.Button();
            this.Password_Field = new System.Windows.Forms.TextBox();
            this.EMail_Field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_BTN
            // 
            this.Login_BTN.Location = new System.Drawing.Point(108, 254);
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Size = new System.Drawing.Size(145, 23);
            this.Login_BTN.TabIndex = 2;
            this.Login_BTN.Text = "Anmelden";
            this.Login_BTN.UseVisualStyleBackColor = true;
            this.Login_BTN.Click += new System.EventHandler(this.Login_Click);
            // 
            // Password_Field
            // 
            this.Password_Field.Location = new System.Drawing.Point(108, 191);
            this.Password_Field.Name = "Password_Field";
            this.Password_Field.Size = new System.Drawing.Size(145, 20);
            this.Password_Field.TabIndex = 1;
            // 
            // EMail_Field
            // 
            this.EMail_Field.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EMail_Field.Location = new System.Drawing.Point(108, 150);
            this.EMail_Field.Name = "EMail_Field";
            this.EMail_Field.Size = new System.Drawing.Size(145, 20);
            this.EMail_Field.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Login_BTN);
            this.panel1.Controls.Add(this.EMail_Field);
            this.panel1.Controls.Add(this.Password_Field);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 426);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-Mail";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_BTN;
        private System.Windows.Forms.TextBox Password_Field;
        private System.Windows.Forms.TextBox EMail_Field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}