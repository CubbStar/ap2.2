using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice
{
    public static class controleur
    {
        public static modele vmodele;

        #region accesseurs
        public static modele getModele()
        {
            return vmodele;
        }
        #endregion

        #region methodes
        public static void init()
        {
            vmodele = new modele();
        }
        #endregion
    }
}
