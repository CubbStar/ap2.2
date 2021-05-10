using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice
{
    class Adherents
    {
        #region propriétés
        //private int id;
        private string nom, prenom, email, mdp;
        private int id;
        #endregion

        #region accesseurs
        //public int Id { get => id; set { if (value >= 0) id = value; } }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public int Id { get => id; set { if (value >= 0) id = value; } }
        #endregion


        #region constructeur
        public Adherents(string nomAd, string prenomAd, string emailAd, string mdpAd, int idAd)
        {
            Nom = nomAd;
            Prenom = prenomAd;
            Email = emailAd;
            Mdp = mdpAd;
            Id = id;

        }

        public Adherents(string nomAd, string prenomAd, string emailAd, string mdpAd)
        {
            Nom = nomAd;
            Prenom = prenomAd;
            Email = emailAd;
            Mdp = mdpAd;

        }   
        #endregion

        #region méthodes
        public string Afficher()
        {
            return (Nom + " " + Prenom);
        }
        #endregion
    }
}
