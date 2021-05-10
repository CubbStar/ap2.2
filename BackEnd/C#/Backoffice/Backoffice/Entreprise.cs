using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice
{
    class Entreprise
    {
        #region propriétés
        private string nom;
        private int id;
        #endregion

        #region accesseurs
        public string Nom { get => nom; set => nom = value; }
        public int Id { get => id; set { if (value >= 0) id = value; } }
        #endregion


        #region constructeur
        public Entreprise(string nomEp)
        {
            Nom = nomEp;
        }

        public Entreprise(string nomEp, int idEp)
        {
            Nom = nomEp;
            Id = idEp;
        }
        #endregion

        #region méthodes
        public string Afficher()
        {
            return (Nom);
        }
        #endregion
    }
}
