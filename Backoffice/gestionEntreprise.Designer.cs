namespace Backoffice
{
    partial class gestionEntreprise
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
            this.gbCreaEntreprise = new System.Windows.Forms.GroupBox();
            this.btCValiderEntreprise = new System.Windows.Forms.Button();
            this.tbCNEntreprise = new System.Windows.Forms.TextBox();
            this.LabCNEnreprise = new System.Windows.Forms.Label();
            this.gbModifEntreprise = new System.Windows.Forms.GroupBox();
            this.rbDesactiverEntreprise = new System.Windows.Forms.RadioButton();
            this.rbActiverEntreprise = new System.Windows.Forms.RadioButton();
            this.cbMEntreprise = new System.Windows.Forms.ComboBox();
            this.btEnregistrerEntreprise = new System.Windows.Forms.Button();
            this.btSupressionEntreprise = new System.Windows.Forms.Button();
            this.tbMNEntreprise = new System.Windows.Forms.TextBox();
            this.labModifNomEntreprise = new System.Windows.Forms.Label();
            this.btRetour = new System.Windows.Forms.Button();
            this.gbCreaEntreprise.SuspendLayout();
            this.gbModifEntreprise.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Montserrat Light", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(109, 31);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(567, 66);
            this.labelTitre.TabIndex = 5;
            this.labelTitre.Text = "GESTION ENTREPRISE";
            // 
            // gbCreaEntreprise
            // 
            this.gbCreaEntreprise.Controls.Add(this.btCValiderEntreprise);
            this.gbCreaEntreprise.Controls.Add(this.tbCNEntreprise);
            this.gbCreaEntreprise.Controls.Add(this.LabCNEnreprise);
            this.gbCreaEntreprise.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreaEntreprise.Location = new System.Drawing.Point(120, 114);
            this.gbCreaEntreprise.Name = "gbCreaEntreprise";
            this.gbCreaEntreprise.Size = new System.Drawing.Size(556, 58);
            this.gbCreaEntreprise.TabIndex = 7;
            this.gbCreaEntreprise.TabStop = false;
            this.gbCreaEntreprise.Text = "CREATION";
            // 
            // btCValiderEntreprise
            // 
            this.btCValiderEntreprise.Font = new System.Drawing.Font("Montserrat ExtraLight", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCValiderEntreprise.Location = new System.Drawing.Point(435, 19);
            this.btCValiderEntreprise.Name = "btCValiderEntreprise";
            this.btCValiderEntreprise.Size = new System.Drawing.Size(115, 31);
            this.btCValiderEntreprise.TabIndex = 9;
            this.btCValiderEntreprise.Text = "VALIDER";
            this.btCValiderEntreprise.UseVisualStyleBackColor = true;
            this.btCValiderEntreprise.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tbCNEntreprise
            // 
            this.tbCNEntreprise.Location = new System.Drawing.Point(203, 19);
            this.tbCNEntreprise.Name = "tbCNEntreprise";
            this.tbCNEntreprise.Size = new System.Drawing.Size(226, 31);
            this.tbCNEntreprise.TabIndex = 8;
            // 
            // LabCNEnreprise
            // 
            this.LabCNEnreprise.AutoSize = true;
            this.LabCNEnreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCNEnreprise.Location = new System.Drawing.Point(6, 22);
            this.LabCNEnreprise.Name = "LabCNEnreprise";
            this.LabCNEnreprise.Size = new System.Drawing.Size(191, 26);
            this.LabCNEnreprise.TabIndex = 0;
            this.LabCNEnreprise.Text = "NOM ENTREPRISE";
            // 
            // gbModifEntreprise
            // 
            this.gbModifEntreprise.Controls.Add(this.rbDesactiverEntreprise);
            this.gbModifEntreprise.Controls.Add(this.rbActiverEntreprise);
            this.gbModifEntreprise.Controls.Add(this.cbMEntreprise);
            this.gbModifEntreprise.Controls.Add(this.btEnregistrerEntreprise);
            this.gbModifEntreprise.Controls.Add(this.btSupressionEntreprise);
            this.gbModifEntreprise.Controls.Add(this.tbMNEntreprise);
            this.gbModifEntreprise.Controls.Add(this.labModifNomEntreprise);
            this.gbModifEntreprise.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModifEntreprise.Location = new System.Drawing.Point(120, 196);
            this.gbModifEntreprise.Name = "gbModifEntreprise";
            this.gbModifEntreprise.Size = new System.Drawing.Size(556, 205);
            this.gbModifEntreprise.TabIndex = 9;
            this.gbModifEntreprise.TabStop = false;
            this.gbModifEntreprise.Text = "MODIFICATION";
            // 
            // rbDesactiverEntreprise
            // 
            this.rbDesactiverEntreprise.AutoSize = true;
            this.rbDesactiverEntreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDesactiverEntreprise.Location = new System.Drawing.Point(149, 117);
            this.rbDesactiverEntreprise.Name = "rbDesactiverEntreprise";
            this.rbDesactiverEntreprise.Size = new System.Drawing.Size(155, 30);
            this.rbDesactiverEntreprise.TabIndex = 16;
            this.rbDesactiverEntreprise.TabStop = true;
            this.rbDesactiverEntreprise.Text = "DESACTIVER";
            this.rbDesactiverEntreprise.UseVisualStyleBackColor = true;
            // 
            // rbActiverEntreprise
            // 
            this.rbActiverEntreprise.AutoSize = true;
            this.rbActiverEntreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActiverEntreprise.Location = new System.Drawing.Point(6, 117);
            this.rbActiverEntreprise.Name = "rbActiverEntreprise";
            this.rbActiverEntreprise.Size = new System.Drawing.Size(114, 30);
            this.rbActiverEntreprise.TabIndex = 15;
            this.rbActiverEntreprise.TabStop = true;
            this.rbActiverEntreprise.Text = "ACTIVER";
            this.rbActiverEntreprise.UseVisualStyleBackColor = true;
            // 
            // cbMEntreprise
            // 
            this.cbMEntreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMEntreprise.FormattingEnabled = true;
            this.cbMEntreprise.Items.AddRange(new object[] {
            "Oba",
            "Nissin",
            "Nissan",
            "Subaru",
            "Toyota"});
            this.cbMEntreprise.Location = new System.Drawing.Point(6, 30);
            this.cbMEntreprise.Name = "cbMEntreprise";
            this.cbMEntreprise.Size = new System.Drawing.Size(544, 34);
            this.cbMEntreprise.TabIndex = 14;
            this.cbMEntreprise.SelectedIndexChanged += new System.EventHandler(this.CbMEntreprise_SelectedIndexChanged);
            // 
            // btEnregistrerEntreprise
            // 
            this.btEnregistrerEntreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnregistrerEntreprise.Location = new System.Drawing.Point(6, 157);
            this.btEnregistrerEntreprise.Name = "btEnregistrerEntreprise";
            this.btEnregistrerEntreprise.Size = new System.Drawing.Size(270, 42);
            this.btEnregistrerEntreprise.TabIndex = 13;
            this.btEnregistrerEntreprise.Text = "ENREGISTRER";
            this.btEnregistrerEntreprise.UseVisualStyleBackColor = true;
            this.btEnregistrerEntreprise.Click += new System.EventHandler(this.btEnregistrerEntreprise_Click);
            // 
            // btSupressionEntreprise
            // 
            this.btSupressionEntreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupressionEntreprise.Location = new System.Drawing.Point(280, 157);
            this.btSupressionEntreprise.Name = "btSupressionEntreprise";
            this.btSupressionEntreprise.Size = new System.Drawing.Size(270, 42);
            this.btSupressionEntreprise.TabIndex = 11;
            this.btSupressionEntreprise.Text = "SUPRESSION";
            this.btSupressionEntreprise.UseVisualStyleBackColor = true;
            this.btSupressionEntreprise.Click += new System.EventHandler(this.btSupressionEntreprise_Click);
            // 
            // tbMNEntreprise
            // 
            this.tbMNEntreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMNEntreprise.Location = new System.Drawing.Point(229, 76);
            this.tbMNEntreprise.Name = "tbMNEntreprise";
            this.tbMNEntreprise.Size = new System.Drawing.Size(321, 31);
            this.tbMNEntreprise.TabIndex = 10;
            // 
            // labModifNomEntreprise
            // 
            this.labModifNomEntreprise.AutoSize = true;
            this.labModifNomEntreprise.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labModifNomEntreprise.Location = new System.Drawing.Point(1, 79);
            this.labModifNomEntreprise.Name = "labModifNomEntreprise";
            this.labModifNomEntreprise.Size = new System.Drawing.Size(214, 26);
            this.labModifNomEntreprise.TabIndex = 9;
            this.labModifNomEntreprise.Text = "MODIFICATION NOM";
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
            // gestionEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.gbModifEntreprise);
            this.Controls.Add(this.gbCreaEntreprise);
            this.Controls.Add(this.labelTitre);
            this.Name = "gestionEntreprise";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gestionEntreprise_Load);
            this.gbCreaEntreprise.ResumeLayout(false);
            this.gbCreaEntreprise.PerformLayout();
            this.gbModifEntreprise.ResumeLayout(false);
            this.gbModifEntreprise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.GroupBox gbCreaEntreprise;
        private System.Windows.Forms.GroupBox gbModifEntreprise;
        private System.Windows.Forms.TextBox tbCNEntreprise;
        private System.Windows.Forms.Label LabCNEnreprise;
        private System.Windows.Forms.TextBox tbMNEntreprise;
        private System.Windows.Forms.Label labModifNomEntreprise;
        private System.Windows.Forms.Button btSupressionEntreprise;
        private System.Windows.Forms.ComboBox cbMEntreprise;
        private System.Windows.Forms.Button btEnregistrerEntreprise;
        private System.Windows.Forms.Button btCValiderEntreprise;
        private System.Windows.Forms.RadioButton rbDesactiverEntreprise;
        private System.Windows.Forms.RadioButton rbActiverEntreprise;
        private System.Windows.Forms.Button btRetour;
    }
}