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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbActiver = new System.Windows.Forms.CheckBox();
            this.cbDesactiver = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(120, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 58);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CREATION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM ENTREPRISE";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 31);
            this.textBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbDesactiver);
            this.groupBox1.Controls.Add(this.cbActiver);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(120, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 205);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODIFICATION";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(229, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(321, 31);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "MODIFICATION NOM";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "SUPRESSION";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbActiver
            // 
            this.cbActiver.AutoSize = true;
            this.cbActiver.Checked = true;
            this.cbActiver.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActiver.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActiver.Location = new System.Drawing.Point(6, 117);
            this.cbActiver.Name = "cbActiver";
            this.cbActiver.Size = new System.Drawing.Size(115, 30);
            this.cbActiver.TabIndex = 10;
            this.cbActiver.Text = "ACTIVER";
            this.cbActiver.UseVisualStyleBackColor = true;
            this.cbActiver.CheckedChanged += new System.EventHandler(this.CbActiver_CheckedChanged);
            // 
            // cbDesactiver
            // 
            this.cbDesactiver.AutoSize = true;
            this.cbDesactiver.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesactiver.Location = new System.Drawing.Point(181, 117);
            this.cbDesactiver.Name = "cbDesactiver";
            this.cbDesactiver.Size = new System.Drawing.Size(156, 30);
            this.cbDesactiver.TabIndex = 12;
            this.cbDesactiver.Text = "DESACTIVER";
            this.cbDesactiver.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(6, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 42);
            this.button2.TabIndex = 13;
            this.button2.Text = "ENREGISTRER";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Montserrat Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Oba",
            "Nissin",
            "Nissan",
            "Subaru",
            "Toyota"});
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(544, 34);
            this.comboBox1.TabIndex = 14;
            // 
            // gestionEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelTitre);
            this.Name = "gestionEntreprise";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDesactiver;
        private System.Windows.Forms.CheckBox cbActiver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}