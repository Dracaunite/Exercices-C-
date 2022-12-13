using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnAsterix
{
    class Personnage
    {
        // attributs (1 par ligne normalement)
        private string nom, adresse, fonction, arme;
        private int nbCombats, force, nbVictoire;
        private bool potion;

        private Personnage (string unNom, string uneAdresse, string uneFonction, int unNbCombat, string uneArme, bool unePotion, int uneForce, int unNbVictoire)
        {
            this.nom = unNom;
            this.adresse = uneAdresse;
            this.fonction = uneFonction;
            this.nbCombats = unNbCombat;
            this.force = uneForce;
            this.nbVictoire = unNbVictoire;
            this.potion = unePotion;
        }
    }
}
