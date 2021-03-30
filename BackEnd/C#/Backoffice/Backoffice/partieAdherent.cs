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
    public partial class partieAdherent : Form
    {
        public partieAdherent()
        {
            InitializeComponent();
        }

        private void BtPartieAdherent_Click(object sender, EventArgs e)
        {
            this.Hide();
            gestionEntreprise objgestionEntreprise = new gestionEntreprise();
            objgestionEntreprise.FormClosed += (s, args) => this.Close();
            objgestionEntreprise.Show();
        }
    }
}
