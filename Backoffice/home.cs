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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void BtPartieAdherent_Click(object sender, EventArgs e)
        {
            this.Hide();
            partieAdherent objPartieAdherent = new partieAdherent();
            objPartieAdherent.FormClosed += (s, args) => this.Close();
            objPartieAdherent.Show();
        }

        private void BtPartieArticle_Click(object sender, EventArgs e)
        {
            this.Hide();
            partieArticle objPartieArticle = new partieArticle();
            objPartieArticle.FormClosed += (s, args) => this.Close();
            objPartieArticle.Show();
        }

        private void BtPartieTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            partieTest objpartieTest = new partieTest();
            objpartieTest.FormClosed += (s, args) => this.Close();
            objpartieTest.Show();
        }
    }
}
