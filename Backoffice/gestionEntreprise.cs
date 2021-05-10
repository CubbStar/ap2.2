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
    public partial class gestionEntreprise : Form
    {
        private Entreprise uneEntreprise;
        List<Entreprise> lesEntreprise = new List<Entreprise>();
        public gestionEntreprise()
        {
            InitializeComponent();
        }

        private void gestionEntreprise_Load(object sender, EventArgs e)
        {
            cbMEntreprise.Items.Clear();
            controleur.init();
            controleur.getModele().seconnecter();
            // A comprendre : que fait cette méthode ? quand est-elle déclenchée ?
       
            if (controleur.vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
                MessageBox.Show("BD connectée");
                controleur.vmodele.charger_Entreprise("entreprise");
                // si le chargement s’est bien passé
                if (controleur.vmodele.Chargement)
                {
                    DataTable dt = controleur.vmodele.DT2;

                    // remplissage de la collection à partir du dataTable chargé
                    // on parcourt tout le dataTable
                    for (int i = 0; i < controleur.vmodele.DT2.Rows.Count; i++)
                    {
                        // on ajoute chaque tupe du dataTable dans la collection
                        lesEntreprise.Add(new Entreprise(dt.Rows[i]["Nom_Entreprise"].ToString()));
                    }
                    chargerCombo(); 
                }
            }
        }

        private void chargerCombo()
        {
            cbMEntreprise.Items.Clear();
            foreach (Entreprise E in lesEntreprise)
            {
                cbMEntreprise.Items.Add(E.Nom);
            }
            controleur.vmodele.charger_Entreprise("entreprise");
            DataTable dt = controleur.vmodele.DT2;
            lesEntreprise.Clear();
            for (int i = 0; i < controleur.vmodele.DT2.Rows.Count;i++)
            {
                lesEntreprise.Add(new Entreprise(dt.Rows[i]["Nom_Entreprise"].ToString()));
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (tbCNEntreprise.Text!= "")
            {
                uneEntreprise = new Entreprise(tbCNEntreprise.Text);
                MessageBox.Show(uneEntreprise.Afficher());
                lesEntreprise.Add(uneEntreprise);

                //bool rep = controleur.vmodele.AjoutEp(tbCNEntreprise.Text);
                bool rep = controleur.vmodele.Ajout("entreprise",tbCNEntreprise.Text.Split(';'),"Nom_Entreprise");
                if (rep)
                {
                    MessageBox.Show("BIEN inséré dans la BD");
                    // mise à jour des données dans le comboBox
                    chargerCombo(); // pour mettre à jour la comboBox
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
            partieAdherent objpartieAdherent = new partieAdherent();
            objpartieAdherent.FormClosed += (s, args) => this.Close();
            objpartieAdherent.Show();
        }

        private void CbMEntreprise_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbMEntreprise.SelectedIndex;
            MessageBox.Show(Convert.ToString(index));
            if (index != -1)
            {
                Entreprise E = lesEntreprise[index];
                tbCNEntreprise.Text = E.Nom;
            }
        }

        private void btSupressionEntreprise_Click(object sender, EventArgs e)
        {
            int index = cbMEntreprise.SelectedIndex;
            string strEntreprise = cbMEntreprise.Text;
            if (strEntreprise != "")
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer " + strEntreprise + " ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    bool rep = controleur.vmodele.suppr_Entreprise(strEntreprise);
                    if (rep)
                    {
                        controleur.init();
                        controleur.vmodele.seconnecter();

                        lesEntreprise.RemoveAt(index);
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

        private void btEnregistrerEntreprise_Click(object sender, EventArgs e)
        {

            int index = cbMEntreprise.SelectedIndex;
            if (index != -1)
            {
                if (tbMNEntreprise.Text != "")
                {
                    lesEntreprise[index].Nom = tbMNEntreprise.Text;
                    int id = Convert.ToInt32(controleur.vmodele.DT2.Rows[index]["ID_Entreprise"]);
                    bool rep = controleur.vmodele.modifEp(tbMNEntreprise.Text, id);
                    // A COMPLETER : mettre à jour toutes les autres propriétés du bien sélectionné à partir des informations saisies sur l'interface
                    if (rep==true)
                    {
                        MessageBox.Show("Bien modifié");
                        chargerCombo(); // pour mettre à jour la comboBox
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la modification");
                        chargerCombo(); // pour mettre à jour la comboBox
                    }


                }
            }
        }
    }
}
