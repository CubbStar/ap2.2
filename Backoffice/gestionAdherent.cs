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
    public partial class gestionAdherent : Form
    {
        private Adherents unAdherent;
        List<Adherents> lesAdherents = new List<Adherents>();
        private Entreprise uneEntreprise;
        List<Entreprise> lesEntreprise = new List<Entreprise>();
        private DataTable dT1 = new DataTable();

        public gestionAdherent()
        {
            InitializeComponent();
        }
        private void GestionAdherent_Load(object sender, EventArgs e)
        {
            
            controleur.init();
            controleur.getModele().seconnecter();
            if (controleur.vmodele.Connopen == false)
            {
                MessageBox.Show("Erreur dans la connexion");
            }
            else
            {
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
                        lesEntreprise.Add(new Entreprise(dt.Rows[i]["ID_Entreprise"].ToString() + ";"+dt.Rows[i]["Nom_Entreprise"].ToString()));
                    }
                    chargerComboEp();
                }

                // --- Partie Adhérents
                controleur.vmodele.charger_Adherent("adherents");
                // si le chargement s’est bien passé
                if (controleur.vmodele.Chargement)
                {
                    DataTable dt = controleur.vmodele.DT1;
                    
                    // remplissage de la collection à partir du dataTable chargé
                    // on parcourt tout le dataTable
                    for (int i = 0; i < controleur.vmodele.DT1.Rows.Count; i++)
                    {
                        // on ajoute chaque tupe du dataTable dans la collection
                        lesAdherents.Add(new Adherents(dt.Rows[i]["nom"].ToString(), dt.Rows[i]["prenom"].ToString(), dt.Rows[i]["email"].ToString(), dt.Rows[i]["mdp"].ToString()));
                    }
                    chargerCombo(); // méthode à ajouter plus bas
                }
            }
        }

        private void chargerCombo()
        {
            cbAdherent.Items.Clear();
            foreach (Adherents A in lesAdherents)
            {
                cbAdherent.Items.Add(A.Nom + " " + A.Prenom + " " + A.Email);
            }
        }

        private void chargerComboEp()
        {
            cbCEntreprise.Items.Clear();
            cbMEntreprise.Items.Clear();
            foreach (Entreprise E in lesEntreprise)
            {
                cbCEntreprise.Items.Add(E.Nom);
                cbMEntreprise.Items.Add(E.Nom);
            }
            controleur.vmodele.charger_Entreprise("entreprise");
            DataTable dt = controleur.vmodele.DT2;
            lesEntreprise.Clear();
            for (int i = 0; i < controleur.vmodele.DT2.Rows.Count; i++)
            {
                lesEntreprise.Add(new Entreprise(dt.Rows[i]["Nom_Entreprise"].ToString()));
            }
        }


        private void BtCValider_Click(object sender, EventArgs e)
        {
            string strTemp;
            
            if (tbCNom.Text != "" && tbCPrenom.Text != "" && tbCEmail.Text != "" && tbCMdp.Text != "" && cbCEntreprise.SelectedIndex != -1)
            {
                
                unAdherent = new Adherents(tbCNom.Text, tbCPrenom.Text, tbCEmail.Text, tbCMdp.Text, cbCEntreprise.SelectedIndex);
                lesAdherents.Add(unAdherent);

                string[] tabEntreprise= cbCEntreprise.Text.Split(';');

                strTemp = tbCNom.Text + ";" + tbCPrenom.Text + ";" + tbCEmail.Text + ";" + tbCMdp.Text + ";" + tabEntreprise[0] + ";1";
                bool rep = controleur.vmodele.Ajout("adherents",strTemp.Split(';'), "nom;prenom;email;mdp;ID_Entreprise;1");
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

        private void btMSupprimer_Click(object sender, EventArgs e)
        {
            int index = cbAdherent.SelectedIndex;
            string strAd = cbAdherent.Text;
            if (strAd != "")
            {
                DialogResult c = MessageBox.Show("Etes-vous sûr de vouloir supprimer " + strAd + " ?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (c == DialogResult.Yes)
                {
                    // --- decoupage
                    string[] tabAd = strAd.Split(' ');

                    //int id = Convert.ToInt32(controleur.vmodele.DT2.Rows[index]["ID_Entreprise"]);
                    bool rep = controleur.vmodele.suppr_Adherent(tabAd[0]);
                    if (rep)
                    {
                        controleur.init();
                        controleur.vmodele.seconnecter();

                        lesAdherents.RemoveAt(index);
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
            int index = cbMEntreprise.SelectedIndex;
            if (index != -1)
            {
                if (tbMNom.Text != "" || tbMPrenom.Text != "" || tbMEmail.Text != "" || tbMMdp.Text != "")
                {

                    // --- decoupage
                    controleur.vmodele.charger_Adherent("adherents");
                    DataTable dt = controleur.vmodele.DT1;
                    string strAdherent=controleur.vmodele.dT1.Rows[1]["ID_Adherent"].ToString();

                    string[] tabEntreprise = cbMEntreprise.Text.Split(';');

                    lesEntreprise[index].Nom = tbMNom.Text;
                    bool rep = controleur.vmodele.modifAd(tbMNom.Text, tbMPrenom.Text, tbMEmail.Text, tbMMdp.Text, Convert.ToInt32(tabEntreprise[0]), Convert.ToInt32(strAdherent));
                    if (rep == true)
                    {
                        MessageBox.Show("Bien modifié");
                        // mise à jour des données dans le comboBox
                        chargerCombo(); // pour mettre à jour la comboBox
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la modification");
                        chargerCombo(); // pour mettre à jour la comboBox
                    }
                }
                else
                {
                    MessageBox.Show("Erreur, il faut saisir le nom, le prenom, l'email et le mot de passe pour valider.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbAdherent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbAdherent.SelectedIndex;
            MessageBox.Show(Convert.ToString(index));
            if (index != -1)
            {
                Adherents E = lesAdherents[index];
                tbCNom.Text = E.Nom;
                Console.WriteLine(index);
            }
        }
    }
}
