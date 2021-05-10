using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice
{
    class Themes
    {
        private string cat; //proporiété

        public string Cat { get => cat; set => cat = value; }//accesseur

        public Themes(string theme)
        {
            Cat = theme;
        }

        public string Afficher()
        {
            return (cat);
        }
    }


}
