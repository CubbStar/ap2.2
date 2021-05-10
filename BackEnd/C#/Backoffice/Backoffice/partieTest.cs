using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backoffice
{
    public partial class partieTest : Form
    {
        private Test unTest;
        List<Test> lesTests = new List<Test>();
        private Themes unTheme;
        List<Themes> lesThemes = new List<Themes>();
        public partieTest()
        {
            InitializeComponent();
        }

        private void partieTest_Load(object sender, EventArgs e)
        {
            controleur.init();
            controleur.getModele().seconnecter();
            if (controleur.vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                controleur.vmodele.charger_Test("test");
                // si le chargement s’est bien passé
                controleur.vmodele.charger_Themes("themes");
                // si le chargement s’est bien passé
                if (controleur.vmodele.Chargement)
                {
                    DataTable dt = controleur.vmodele.DT5;

                    // remplissage de la collection à partir du dataTable chargé
                    // on parcourt tout le dataTable
                    for (int i = 0; i < controleur.vmodele.DT5.Rows.Count; i++)
                    {
                        // on ajoute chaque tupe du dataTable dans la collection
                        lesThemes.Add(new Themes(dt.Rows[i]["Themes"].ToString()));
                    }
                    chargerComboTh();
                }
            }
        }

        private void chargerComboTh()
        {
            cbArticle.Items.Clear();
            foreach (Themes T in lesThemes)
            {
                cbArticle.Items.Add(T.Cat);
            }
            controleur.vmodele.charger_Themes("themes");
            DataTable dt = controleur.vmodele.DT5;

            for (int i = 0; i < controleur.vmodele.DT5.Rows.Count; i++)
            {
                lesThemes.Add(new Themes(dt.Rows[i]["Themes"].ToString()));
            }
        }

        private void BtRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            home objhome = new home();
            objhome.FormClosed += (s, args) => this.Close();
            objhome.Show();
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            if (tbQuestion.Text != "" && tbReponse.Text != "")
            {

                unTest = new Test(tbQuestion.Text, tbReponse.Text);
                lesTests.Add(unTest);

                int index = cbArticle.SelectedIndex;

                DataTable dt = controleur.vmodele.DT5;
                int intIDTheme = Convert.ToInt32(controleur.vmodele.DT5.Rows[index]["ID_Themes"]);

                bool rep = controleur.vmodele.AjoutTest(tbQuestion.Text, tbQuestion.Text, intIDTheme);
                if (rep)
                {
                    MessageBox.Show("BIEN inséré dans la BD");
                }
                else
                {
                    MessageBox.Show("Pb dans l'insertion");
                }
            }
            else
            {
                MessageBox.Show("Erreur de saisie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
