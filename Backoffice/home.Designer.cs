namespace Backoffice
{
    partial class home
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelTitre = new System.Windows.Forms.Label();
            this.btPartieAdherent = new System.Windows.Forms.Button();
            this.btPartieArticle = new System.Windows.Forms.Button();
            this.btPartieTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Montserrat Light", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(130, 24);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(500, 66);
            this.labelTitre.TabIndex = 2;
            this.labelTitre.Text = "CYBERPROTECTIVE";
            // 
            // btPartieAdherent
            // 
            this.btPartieAdherent.BackColor = System.Drawing.Color.White;
            this.btPartieAdherent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btPartieAdherent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btPartieAdherent.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPartieAdherent.ForeColor = System.Drawing.Color.Black;
            this.btPartieAdherent.Location = new System.Drawing.Point(151, 168);
            this.btPartieAdherent.Name = "btPartieAdherent";
            this.btPartieAdherent.Size = new System.Drawing.Size(228, 99);
            this.btPartieAdherent.TabIndex = 3;
            this.btPartieAdherent.Text = "PARTIE CLIENT";
            this.btPartieAdherent.UseVisualStyleBackColor = false;
            this.btPartieAdherent.Click += new System.EventHandler(this.BtPartieAdherent_Click);
            // 
            // btPartieArticle
            // 
            this.btPartieArticle.BackColor = System.Drawing.Color.White;
            this.btPartieArticle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btPartieArticle.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPartieArticle.ForeColor = System.Drawing.Color.Black;
            this.btPartieArticle.Location = new System.Drawing.Point(385, 168);
            this.btPartieArticle.Name = "btPartieArticle";
            this.btPartieArticle.Size = new System.Drawing.Size(228, 99);
            this.btPartieArticle.TabIndex = 4;
            this.btPartieArticle.Text = "PARTIE ARTICLE";
            this.btPartieArticle.UseVisualStyleBackColor = false;
            this.btPartieArticle.Click += new System.EventHandler(this.BtPartieArticle_Click);
            // 
            // btPartieTest
            // 
            this.btPartieTest.BackColor = System.Drawing.Color.White;
            this.btPartieTest.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btPartieTest.Font = new System.Drawing.Font("Montserrat", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPartieTest.ForeColor = System.Drawing.Color.Black;
            this.btPartieTest.Location = new System.Drawing.Point(267, 273);
            this.btPartieTest.Name = "btPartieTest";
            this.btPartieTest.Size = new System.Drawing.Size(228, 99);
            this.btPartieTest.TabIndex = 5;
            this.btPartieTest.Text = "PARTIE TEST";
            this.btPartieTest.UseVisualStyleBackColor = false;
            this.btPartieTest.Click += new System.EventHandler(this.BtPartieTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(165)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(77, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(602, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btPartieTest);
            this.Controls.Add(this.btPartieArticle);
            this.Controls.Add(this.btPartieAdherent);
            this.Controls.Add(this.labelTitre);
            this.Name = "home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Button btPartieAdherent;
        private System.Windows.Forms.Button btPartieArticle;
        private System.Windows.Forms.Button btPartieTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

