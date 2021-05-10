using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Backoffice
{
    public class modele
    {
        #region Propriété
        private MySqlConnection myConnection; // objet de connexion
        private bool connopen = false; // test si la connexion est faite
        private bool chargement = false; // test si le chargement d'une requête est fait
        public DataTable dT1 = new DataTable();
        private DataTable dT2 = new DataTable();
        private DataTable dT3 = new DataTable();
        private DataTable dT4 = new DataTable();
        private DataTable dT5 = new DataTable();
        #endregion

        #region accesseurs
        public bool Connopen { get => connopen; }
        public bool Chargement { get => chargement; }
        public DataTable DT1 { get => dT1; set => dT1 = value; }
        public DataTable DT2 { get => dT2; set => dT2 = value; }
        public DataTable DT3 { get => dT3; set => dT3 = value; }
        public DataTable DT4 { get => dT4; set => dT4 = value; }
        public DataTable DT5 { get => dT5; set => dT5 = value; }
        #endregion

        #region constructeur
        public modele() { }
        #endregion

        #region méthodes 
        /// <summary>
        /// Méthode pour se connecter à la BD
        /// </summary>
        public void seconnecter()
        {
            // paramètres de connexion à modifier selon sa BD et son serveur de BD
            string myConnectionString = "Database=ActuSecu;Data Source=localhost;User Id = APPC; Password =AppCSh@rp0R;";
            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                connopen = false;
            }
        }
        /// <summary>
        /// Méthode pour se déconnecter de la BD
        /// </summary>
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void charger(string requete, DataTable DT)
        {
            MySqlCommand command = myConnection.CreateCommand();
            MySqlDataReader reader;
            try
            {
                command.CommandText = requete;
                reader = command.ExecuteReader();
                DT.Load(reader);
                chargement = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur chargement dataTable: " + err, "PBS table",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                chargement = false;
            }
        }
        public void charger_Adherent(string table)
        {
            if (table == "adherents") charger("select * from adherents;", dT1);
        }

        public void charger_Entreprise(string table)
        {
            if (table == "entreprise") charger("select * from entreprise;", dT2);
        }

        public void charger_Article(string table)
        {
            if (table == "article") charger("select * from article;", dT3);
        }

        public void charger_Themes(string table)
        {
            if (table == "themes") charger("select * from themes;", dT5);
        }

        public void charger_(string table, string strMax)
        {
            // *** V1.0 - OR

            string strSql = "";
            if (strMax == "")
            {
                strSql = "select * from " + table;
            }
            else
            {
                strSql = "select MAX(" + strMax + ") from " + table;
            }

            /*if(strWhere!="")
            {
                strSql += " WHERE " + strWhere;
            }*/

            charger(strSql + ";", dT1);
        }

        public void charger_Test(string table)
        {
            if (table == "ActuSecu") charger("select * from questions;", dT4);
        }

        //------------------------------------Adherents--------------------------------------------------------------------------------------------------

        public bool AjoutAd(string nomAd, string prenomAd, string emailAd, string mdpAd)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "insert into adherents values (NULL, @nom, @prenom, @email, @mdp, 1, 1)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de
                command.Parameters.AddWithValue("nom", nomAd);
                command.Parameters.AddWithValue("prenom", prenomAd);
                command.Parameters.AddWithValue("email", emailAd);
                command.Parameters.AddWithValue("mdp", mdpAd);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool modifAd(string nomAd, string prenomAd, string emailAd, string mdpAd, int idEnt, int idAd)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "update adherents set nom = '" + nomAd + "', prenom = '" + prenomAd + "', email = '" + emailAd + "', mdp = '" + mdpAd + "', ID_Entreprise = " + idEnt + " WHERE ID_Adherent = " + idAd;
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool suppr_Adherent(string strAd)
        {
            try
            {
                string requete = "delete from adherents where nom = '" + strAd + "'";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                //command.Parameters.AddWithValue("nom", strAd);
                int i = command.ExecuteNonQuery();
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        public bool Ajout(string strTable, string[] tabElement, string strChamps)
        {
            // *** V1.0 - OR - 08/05/2021 - Creéation de la fonction ajout

            bool boolOk = true;
            try
            {
                String[] tablist = strChamps.Split(';');

                //string requete = "insert into adherents values (NULL, @nom, @prenom, @email, @mdp, @id, 1)";
                string requete2 = "insert into " + strTable + " values (NULL";

                MySqlCommand command = myConnection.CreateCommand();

                for (int j = 0; j < tabElement.Length; j++)
                {
                    if (tabElement[j] != "")
                    {
                        if (IsNumeric(tabElement[j]) == false)
                        {
                            requete2 += ",'" + tabElement[j] + "'";
                        }
                        else
                        {
                            requete2 += "," + tabElement[j];
                        }
                    }
                }

                requete2 += ")";

                command.CommandText = requete2;
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                if (i <= 0) boolOk = false;

                return (boolOk);
            }
            catch
            {
                return false;
            }
        }



        //------------------------------------Entreprise--------------------------------------------------------------------------------------------------
        public bool AjoutEp(string nomEp)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requeteEp = "insert into entreprise values (NULL, @Nom_Entreprise)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requeteEp;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de
                command.Parameters.AddWithValue("Nom_Entreprise", nomEp);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool modifEp(string nomEp, int idEp)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "update entreprise set Nom_Entreprise = @nom where ID_Entreprise = @id";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de
                command.Parameters.AddWithValue("nom", nomEp);
                command.Parameters.AddWithValue("id", idEp);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool suppr_Entreprise(string strEntreprise)
        {
            try
            {
                string requete = "delete from entreprise where Nom_Entreprise = @Nom_Entreprise";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de la méthode
                command.Parameters.AddWithValue("Nom_Entreprise", strEntreprise);
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        //------------------------------------Article--------------------------------------------------------------------------------------------------

        public bool AjoutArt(string tArt, string chapArt, DateTimePicker dArt, string debutArt, string lArt)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "insert into article values (NULL, @Titre, @Chapeau, @Date, @Debut, @Lien, NULL)";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de
                command.Parameters.AddWithValue("Titre", tArt);
                command.Parameters.AddWithValue("Chapeau", chapArt);
                command.Parameters.AddWithValue("Date", dArt.Value);
                command.Parameters.AddWithValue("Debut", debutArt);
                command.Parameters.AddWithValue("Lien", lArt);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }
        public bool Liason(int intIDTheme)
        {
            try
            {
                charger_("article", "ID_Article");
                DataTable dt = controleur.vmodele.DT1;
                int intIDArticle = Convert.ToInt32(controleur.vmodele.DT3.Rows[0][0]);


                string requeteD = "insert into appartenir values (ID_Themes = @ID_Themes,ID_Article = @ID_Article)";
                MySqlCommand commandD = myConnection.CreateCommand();
                commandD.CommandText = requeteD;
                commandD.Parameters.AddWithValue("ID_Article", intIDArticle);
                commandD.Parameters.AddWithValue("ID_Themes", intIDTheme);
                int D = commandD.ExecuteNonQuery(); ;




                // i est positif si l'insertion a pu avoir lieu
                return (D > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool modifArt(string tArt, string chapArt, string debutArt, string lArt, int idArt)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requete = "update entreprise set Titre = @titre, Chapeau = @chapeau, Debut = @debut, Lien = @lien where ID_Article = @id";
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete;
                // mise à jour des paramètres de la requête préparée avec les infos passées en paramètre de
                command.Parameters.AddWithValue("titre", tArt);
                command.Parameters.AddWithValue("chapeau", chapArt);
                command.Parameters.AddWithValue("debut", debutArt);
                command.Parameters.AddWithValue("lien", lArt);
                // Exécution de la requête
                int i = command.ExecuteNonQuery();
                // i est positif si l'insertion a pu avoir lieu
                return (i > 0);
            }
            catch
            {
                return false;
            }
        }

        public bool suppr_Article(int intIdArticle)
        {
            try
            {
                string requete2 = "DELETE FROM appartenir WHERE ID_Article = " + intIdArticle;
                string requete = "DELETE FROM article WHERE ID_Article = " + intIdArticle;
                MySqlCommand command = myConnection.CreateCommand();
                command.CommandText = requete2;
                int i = command.ExecuteNonQuery();
                command.CommandText = requete;
                i = command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }


        //------------------------------------Test--------------------------------------------------------------------------------------------------

        public bool AjoutTest(string qTest, string rTest, int intIDTheme)
        {
            try
            {
                // préparation de la requête avec des paramètres
                string requeteQ = "insert into questions values (NULL, @Questions)";
                MySqlCommand commandQ = myConnection.CreateCommand();
                commandQ.CommandText = requeteQ;
                commandQ.Parameters.AddWithValue("Questions", qTest);
                int i = commandQ.ExecuteNonQuery();

                string requeteR = "insert into propositions values (NULL, @Propositions)";
                MySqlCommand commandR = myConnection.CreateCommand();
                commandR.CommandText = requeteR;
                commandR.Parameters.AddWithValue("Propositions", rTest);
                int j = commandR.ExecuteNonQuery();


                // --- Récupération ID_Question
                charger_("questions", "ID_Question");
                DataTable dt = controleur.vmodele.DT1;
                int intIDQuestion = Convert.ToInt32(controleur.vmodele.DT1.Rows[0][0]);


                string requeteD = "insert into appartenir values (@ID_Themes, @ID_Question)";
                MySqlCommand commandD = myConnection.CreateCommand();
                commandD.CommandText = requeteD;
                commandD.Parameters.AddWithValue("ID_Question", intIDQuestion);
                commandD.Parameters.AddWithValue("ID_Themes", intIDTheme);
                int D = commandD.ExecuteNonQuery();


                // Exécution de la requête


                // i est positif si l'insertion a pu avoir lieu
                return (i > 0 && j > 0 && D > 0);
            }
            catch
            {
                return false;
            }
        }

        //--------------------------------------------Autres---------------------------------------------------------

        public bool IsNumeric(string Nombre)
        {
            int i = 0;
            int nb = 0;
            bool ok = false;
            char[] tabNombre;
            char[] unNb;
            tabNombre = Nombre.ToCharArray(0, Nombre.Length);
            for (i = 0; i < Nombre.Length; i++)
            {
                ok = false;
                while ((nb < 10) && (ok == false))
                {
                    unNb = Convert.ToString(nb).ToCharArray(0, 1);
                    if (tabNombre[i] == unNb[0])
                    {
                        ok = true;
                        nb = 0;
                    }
                    else
                    {
                        if ((i == 0) && (tabNombre[i] == '-'))
                        {
                            ok = true;
                            nb = 0;
                        }
                        else
                        {
                            ok = false;
                            nb++;
                        }
                    }
                }
            }
            return ok;
        }

        #endregion
    }
}