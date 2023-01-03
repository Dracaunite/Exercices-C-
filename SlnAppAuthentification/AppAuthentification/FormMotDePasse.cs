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
    public partial class FormMotDePasse : Form
    {
        public FormMotDePasse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMotDePasse_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            // Cas où le mot de passe est valide
            if (mdpTB.Text == "password")
            {
                // inititalisation de la fenetre FormBienvenue
                FormBienvenue uneFenetreDeBienvenue = new FormBienvenue(nomTB.Text);
                uneFenetreDeBienvenue.Show();
            }

            // Cas où le mot de passe est vide (non renseigné)
            else if (string.IsNullOrEmpty(mdpTB.Text))
            {
                MessageBox.Show("Vous devez saisir un mot de passe non vide !", "MOT DE PASSE VIDE !", MessageBoxButtons.OK);
            }

            // Cas où le mot de passe est invalide
            else
            {
                MessageBox.Show("Vous devez saisir un mot de passe valide !", "ERREUR DE MOT DE PASSE !", MessageBoxButtons.OK);
            }
        }

        private void mdpTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void femerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
