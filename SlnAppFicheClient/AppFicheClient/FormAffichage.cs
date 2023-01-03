using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFicheClient
{
    public partial class FormAffichage : Form
    {
        public FormAffichage()
        {
            InitializeComponent();
        }

        private void affichageLb_Click(object sender, EventArgs e)
        {

        }

        private void fermerBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
