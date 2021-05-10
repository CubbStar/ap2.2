namespace Backoffice
{
    partial class partieArticle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbArticle = new System.Windows.Forms.ComboBox();
            this.btMValider = new System.Windows.Forms.Button();
            this.btMSupprimer = new System.Windows.Forms.Button();
            this.rbMDesactiver = new System.Windows.Forms.RadioButton();
            this.rbMActiver = new System.Windows.Forms.RadioButton();
            this.tbMLien = new System.Windows.Forms.TextBox();
            this.tbMIntro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMChapeau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMTitre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCLien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateCArticle = new System.Windows.Forms.DateTimePicker();
            this.btCValider = new System.Windows.Forms.Button();
            this.tbCDebut = new System.Windows.Forms.TextBox();
            this.tbCChapeau = new System.Windows.Forms.TextBox();
            this.tbCTArticle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btRetour = new System.Windows.Forms.Button();
            this.cbThemes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Montserrat Light", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(172, 32);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(418, 66);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "PARTIE ARTICLE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbArticle);
            this.groupBox1.Controls.Add(this.btMValider);
            this.groupBox1.Controls.Add(this.btMSupprimer);
            this.groupBox1.Controls.Add(this.rbMDesactiver);
            this.groupBox1.Controls.Add(this.rbMActiver);
            this.groupBox1.Controls.Add(this.tbMLien);
            this.groupBox1.Controls.Add(this.tbMIntro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbMChapeau);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbMTitre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(397, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 293);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODIFICATION";
            // 
            // cbArticle
            // 
            this.cbArticle.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArticle.FormattingEnabled = true;
            this.cbArticle.Location = new System.Drawing.Point(9, 30);
            this.cbArticle.Name = "cbArticle";
            this.cbArticle.Size = new System.Drawing.Size(308, 26);
            this.cbArticle.TabIndex = 13;
            this.cbArticle.SelectedIndexChanged += new System.EventHandler(this.cbArticle_SelectedIndexChanged);
            // 
            // btMValider
            // 
            this.btMValider.BackColor = System.Drawing.Color.Transparent;
            this.btMValider.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMValider.Location = new System.Drawing.Point(6, 251);
            this.btMValider.Name = "btMValider";
            this.btMValider.Size = new System.Drawing.Size(157, 31);
            this.btMValider.TabIndex = 33;
            this.btMValider.Text = "VALIDER";
            this.btMValider.UseVisualStyleBackColor = false;
            this.btMValider.Click += new System.EventHandler(this.btMValider_Click);
            // 
            // btMSupprimer
            // 
            this.btMSupprimer.BackColor = System.Drawing.Color.Transparent;
            this.btMSupprimer.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMSupprimer.Location = new System.Drawing.Point(169, 251);
            this.btMSupprimer.Name = "btMSupprimer";
            this.btMSupprimer.Size = new System.Drawing.Size(148, 31);
            this.btMSupprimer.TabIndex = 32;
            this.btMSupprimer.Text = "SUPPRIMER";
            this.btMSupprimer.UseVisualStyleBackColor = false;
            this.btMSupprimer.Click += new System.EventHandler(this.btMSupprimer_Click);
            // 
            // rbMDesactiver
            // 
            this.rbMDesactiver.AutoSize = true;
            this.rbMDesactiver.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMDesactiver.Location = new System.Drawing.Point(133, 223);
            this.rbMDesactiver.Name = "rbMDesactiver";
            this.rbMDesactiver.Size = new System.Drawing.Size(110, 22);
            this.rbMDesactiver.TabIndex = 31;
            this.rbMDesactiver.TabStop = true;
            this.rbMDesactiver.Text = "DESACTIVER";
            this.rbMDesactiver.UseVisualStyleBackColor = true;
            // 
            // rbMActiver
            // 
            this.rbMActiver.AutoSize = true;
            this.rbMActiver.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMActiver.Location = new System.Drawing.Point(9, 223);
            this.rbMActiver.Name = "rbMActiver";
            this.rbMActiver.Size = new System.Drawing.Size(82, 22);
            this.rbMActiver.TabIndex = 30;
            this.rbMActiver.TabStop = true;
            this.rbMActiver.Text = "ACTIVER";
            this.rbMActiver.UseVisualStyleBackColor = true;
            // 
            // tbMLien
            // 
            this.tbMLien.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMLien.Location = new System.Drawing.Point(52, 181);
            this.tbMLien.Name = "tbMLien";
            this.tbMLien.Size = new System.Drawing.Size(265, 23);
            this.tbMLien.TabIndex = 29;
            // 
            // tbMIntro
            // 
            this.tbMIntro.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMIntro.Location = new System.Drawing.Point(125, 146);
            this.tbMIntro.Name = "tbMIntro";
            this.tbMIntro.Size = new System.Drawing.Size(192, 23);
            this.tbMIntro.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "TITRE";
            // 
            // tbMChapeau
            // 
            this.tbMChapeau.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMChapeau.Location = new System.Drawing.Point(86, 109);
            this.tbMChapeau.Name = "tbMChapeau";
            this.tbMChapeau.Size = new System.Drawing.Size(231, 23);
            this.tbMChapeau.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "CHAPEAU";
            // 
            // tbMTitre
            // 
            this.tbMTitre.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMTitre.Location = new System.Drawing.Point(56, 70);
            this.tbMTitre.Name = "tbMTitre";
            this.tbMTitre.Size = new System.Drawing.Size(261, 23);
            this.tbMTitre.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "INTRODUCTION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "LIEN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbThemes);
            this.groupBox2.Controls.Add(this.tbCLien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateCArticle);
            this.groupBox2.Controls.Add(this.btCValider);
            this.groupBox2.Controls.Add(this.tbCDebut);
            this.groupBox2.Controls.Add(this.tbCChapeau);
            this.groupBox2.Controls.Add(this.tbCTArticle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(68, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 282);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CREATION";
            // 
            // tbCLien
            // 
            this.tbCLien.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCLien.Location = new System.Drawing.Point(52, 176);
            this.tbCLien.Name = "tbCLien";
            this.tbCLien.Size = new System.Drawing.Size(265, 23);
            this.tbCLien.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "LIEN";
            // 
            // dateCArticle
            // 
            this.dateCArticle.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCArticle.Location = new System.Drawing.Point(56, 99);
            this.dateCArticle.Name = "dateCArticle";
            this.dateCArticle.Size = new System.Drawing.Size(261, 23);
            this.dateCArticle.TabIndex = 35;
            // 
            // btCValider
            // 
            this.btCValider.BackColor = System.Drawing.Color.Transparent;
            this.btCValider.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCValider.Location = new System.Drawing.Point(9, 245);
            this.btCValider.Name = "btCValider";
            this.btCValider.Size = new System.Drawing.Size(308, 31);
            this.btCValider.TabIndex = 34;
            this.btCValider.Text = "VALIDER";
            this.btCValider.UseVisualStyleBackColor = false;
            this.btCValider.Click += new System.EventHandler(this.BtCValider_Click);
            // 
            // tbCDebut
            // 
            this.tbCDebut.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCDebut.Location = new System.Drawing.Point(67, 138);
            this.tbCDebut.Name = "tbCDebut";
            this.tbCDebut.Size = new System.Drawing.Size(250, 23);
            this.tbCDebut.TabIndex = 21;
            // 
            // tbCChapeau
            // 
            this.tbCChapeau.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCChapeau.Location = new System.Drawing.Point(86, 66);
            this.tbCChapeau.Name = "tbCChapeau";
            this.tbCChapeau.Size = new System.Drawing.Size(231, 23);
            this.tbCChapeau.TabIndex = 19;
            // 
            // tbCTArticle
            // 
            this.tbCTArticle.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCTArticle.Location = new System.Drawing.Point(114, 27);
            this.tbCTArticle.Name = "tbCTArticle";
            this.tbCTArticle.Size = new System.Drawing.Size(203, 23);
            this.tbCTArticle.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "DEBUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "CHAPEAU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITRE ARTICLE";
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Montserrat Light", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetour.Location = new System.Drawing.Point(12, 12);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 15;
            this.btRetour.Text = "RETOUR";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.BtRetour_Click);
            // 
            // cbThemes
            // 
            this.cbThemes.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThemes.FormattingEnabled = true;
            this.cbThemes.Location = new System.Drawing.Point(9, 213);
            this.cbThemes.Name = "cbThemes";
            this.cbThemes.Size = new System.Drawing.Size(308, 26);
            this.cbThemes.TabIndex = 34;
            // 
            // partieArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTitre);
            this.Name = "partieArticle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gestionArticle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbArticle;
        private System.Windows.Forms.Button btMValider;
        private System.Windows.Forms.Button btMSupprimer;
        private System.Windows.Forms.RadioButton rbMDesactiver;
        private System.Windows.Forms.RadioButton rbMActiver;
        private System.Windows.Forms.TextBox tbMLien;
        private System.Windows.Forms.TextBox tbMIntro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMChapeau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMTitre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateCArticle;
        private System.Windows.Forms.Button btCValider;
        private System.Windows.Forms.TextBox tbCDebut;
        private System.Windows.Forms.TextBox tbCChapeau;
        private System.Windows.Forms.TextBox tbCTArticle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCLien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.ComboBox cbThemes;
    }
}