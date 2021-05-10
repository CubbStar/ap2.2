namespace Backoffice
{
    partial class partieAdherent
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.btPartieAdherent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Montserrat Light", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(140, 36);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(492, 66);
            this.labelTitre.TabIndex = 3;
            this.labelTitre.Text = "PARTIE ADHERENT";
            // 
            // btPartieAdherent
            // 
            this.btPartieAdherent.BackColor = System.Drawing.Color.White;
            this.btPartieAdherent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btPartieAdherent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btPartieAdherent.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPartieAdherent.ForeColor = System.Drawing.Color.Black;
            this.btPartieAdherent.Location = new System.Drawing.Point(253, 156);
            this.btPartieAdherent.Name = "btPartieAdherent";
            this.btPartieAdherent.Size = new System.Drawing.Size(249, 99);
            this.btPartieAdherent.TabIndex = 4;
            this.btPartieAdherent.Text = "GESTION ENTREPRISE";
            this.btPartieAdherent.UseVisualStyleBackColor = false;
            this.btPartieAdherent.Click += new System.EventHandler(this.BtPartieAdherent_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(253, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 99);
            this.button1.TabIndex = 5;
            this.button1.Text = "GESTION ADHERENT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(12, 12);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 14;
            this.btRetour.Text = "RETOUR";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.BtRetour_Click);
            // 
            // partieAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btPartieAdherent);
            this.Controls.Add(this.labelTitre);
            this.Name = "partieAdherent";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button btPartieAdherent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRetour;
    }
}