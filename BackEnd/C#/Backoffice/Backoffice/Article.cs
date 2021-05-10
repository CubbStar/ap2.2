using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice
{
    class Article
    {
        #region propriétés
        private string titre, chapeau, debut, lien;
        private DateTime date;
        #endregion

        #region accesseurs
        public string Titre { get => titre; set => titre = value; }
        public string Chapeau { get => chapeau; set => chapeau = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Debut { get => debut; set => debut = value; }
        public string Lien { get => lien; set => lien = value; }
        #endregion


        #region constructeur
        public Article(string tArt, string chapArt, DateTime dArt, string debutArt, string lArt)
        {
            Titre = tArt;
            Chapeau = chapArt;
            Date = dArt;
            Debut = debutArt;
            Lien = lArt;


        }        
        
        public Article(string tArt, string chapArt, string debutArt, string lArt)
        {
            Titre = tArt;
            Chapeau = chapArt;
            Debut = debutArt;
            Lien = lArt;


        }
        #endregion

        #region méthodes
        public string Afficher()
        {
            return (Titre +" "+ Date);
        }
        #endregion
    }
}
