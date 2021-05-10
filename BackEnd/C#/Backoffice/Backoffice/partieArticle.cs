using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Backoffice
{
    public partial class partieArticle : Form
    {
        private Article unArticle;
        List<Article> lesArticles = new List<Article>();
        private Themes unTheme;
        List<Themes> lesThemes = new List<Themes>();
        public partieArticle()
        {
            InitializeComponent();
        }

        private void gestionArticle_Load(object sender, EventArgs e)
        {
            cbArticle.Items.Clear();
            controleur.init();
            controleur.getModele().seconnecter();
            // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
            foreach (Article A in lesArticles)
            {
                cbArticle.Items.Add(A.Titre);
            }
            if (controleur.vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                controleur.vmodele.charger_Article("article");
                // si le chargement s’est bien passé
                if (controleur.vmodele.Chargement)
                {
                    DataTable dt = controleur.vmodele.DT3;

                    // remplissage de la collection à partir du dataTable chargé
                    // on parcourt tout le dataTable
                    for (int i = 0; i < controleur.vmodele.DT3.Rows.Count; i++)
                    {
                        // on ajoute chaque tupe du dataTable dans la collection
                        lesArticles.Add(new Article(dt.Rows[i]["Titre"].ToString(), dt.Rows[i]["Chapeau"].ToString(), Convert.ToDateTime(dt.Rows[i]["Date"].ToString()), dt.Rows[i]["Debut"].ToString(), dt.Rows[i]["Lien"].ToString()));
                    }
                    chargerCombo();
                }
            }
        }

        private void chargerCombo()
        {
            cbArticle.Items.Clear();
            foreach (Article E in lesArticles)
            {
                cbArticle.Items.Add(E.Titre);
            }
            controleur.vmodele.charger_Article("article");
            DataTable dt = controleur.vmodele.DT3;
            lesArticles.Clear();
            for (int i = 0; i < controleur.vmodele.DT3.Rows.Count; i++)
            {
                lesArticles.Add(new Article(dt.Rows[i]["Titre"].ToString(), dt.Rows[i]["Chapeau"].ToString(), Convert.ToDateTime(dt.Rows[i]["Date"].ToString()), dt.Rows[i]["Debut"].ToString(), dt.Rows[i]["Lien"].ToString())) ;
            }
        }

        private void BtCValider_Click(object sender, EventArgs e)
        {
            if (tbCTArticle.Text != "" && tbCChapeau.Text != "" && tbCDebut.Text != "" && tbCLien.Text != "")
            {
                unArticle = new Article(tbCTArticle.Text, tbCChapeau.Text, dateCArticle.Value, tbCDebut.Text, tbCLien.Text);
                lesArticles.Add(unArticle);

                bool rep = controleur.vmodele.AjoutArt(tbCTArticle.Text, tbCChapeau.Text, dateCArticle, tbCDebut.Text, tbCLien.Text);
                if (rep)
                {

                }
                else
                {
                    MessageBox.Show("Pb dans l'insertion");
                }
            }
            else
            {
                MessageBox.Show("Erreur, il faut saisir le nom, le prenom, l'email et le mot de passe pour valider.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            home objhome = new home();
            objhome.FormClosed += (s, args) => this.Close();
            objhome.Show();
        }

        private void cbArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbArticle.SelectedIndex;
            if (index != -1)
            {
                Article A = lesArticles[index];
                tbCTArticle.Text = A.Titre;
            }
        }

        private void btMSupprimer_Click(object sender, EventArgs e)
        {
            int index = cbArticle.SelectedIndex;
            string strAd = cbArticle.Text;
            if (strAd != "")
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer " + strAd + " ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    // --- decoupage

                    int intIdArticle = Convert.ToInt32(controleur.vmodele.DT3.Rows[index]["ID_Article"]);
                    bool rep = controleur.vmodele.suppr_Article(intIdArticle);
                    if (rep == true)
                    {
                        controleur.init();
                        controleur.vmodele.seconnecter();

                        lesArticles.RemoveAt(index);
                        chargerCombo();
                        MessageBox.Show("Suppression du bien effectué");
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la suppression");
                    }
                }
            }
        }

        private void btMValider_Click(object sender, EventArgs e)
        {
            int index = cbArticle.SelectedIndex;
            if (index != -1)
            {
                if (tbMTitre.Text != "" || tbMChapeau.Text != "" || tbMIntro.Text != "" || tbMLien.Text != "")
                {

                    unArticle = new Article(tbMTitre.Text, tbMChapeau.Text, tbMIntro.Text, tbMLien.Text);
                    lesArticles.Add(unArticle);
                    int id = Convert.ToInt32(controleur.vmodele.DT3.Rows[index]["ID_Article"]);
                    bool rep = controleur.vmodele.modifArt(tbMTitre.Text, tbMChapeau.Text, tbMIntro.Text, tbMLien.Text, id);
                    if (rep)
                    {
                        MessageBox.Show("BIEN modifié dans la BD");
                        // mise à jour des données dans le comboBox
                        chargerCombo(); // pour mettre à jour la comboBox
                    }
                    else
                    {
                        MessageBox.Show("Pb de modification");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur, il faut saisir le nom, le prenom, l'email et le mot de passe pour valider.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
