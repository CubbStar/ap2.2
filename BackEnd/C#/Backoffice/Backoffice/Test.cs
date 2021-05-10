using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice
{
    class Test
    {
        #region propriétés
        private string question, reponse;
        #endregion

        #region accesseurs
        public string Question { get => question; set => question = value; }
        public string Reponse { get => reponse; set => reponse = value; }
        #endregion


        #region constructeur
        public Test(string qTest,string rTest)
        {
            Question = qTest;
            Reponse = rTest;
        }
        #endregion

        #region méthodes
        public string Afficher()
        {
            return (question + " " + reponse);
        }
        #endregion
    }
}
