using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAuthentification
{
    public partial class FormBienvenue : Form
    {
        public FormBienvenue(string unNom)
        {
            InitializeComponent();
            msgLb.Text = "Bienvenue " + unNom + " !";
        }

        private void fermerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fermerToutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
