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

        // Création du constructeur
        public Personnage (string unNom, string uneAdresse, string uneFonction, int unNbCombat, string uneArme, bool unePotion, int uneForce, int unNbVictoire)
        {
            this.nom = unNom;
            this.adresse = uneAdresse;
            this.fonction = uneFonction;
            this.nbCombats = unNbCombat;
            this.force = uneForce;
            this.nbVictoire = unNbVictoire;
            this.potion = unePotion;
            this.arme = uneArme;
        }

        // Configuration d'un accesseur / mutateur
        public string Nom
        {
            get
            {
                return nom; // On retourne valeur nom (accesseur)
            }

            set
            {
                nom = value; // On peut modifier la valeur nom (mutateur)
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
            }
        }

        public int NbCombats
        {
            get
            {
                return nbCombats;
            }

            set
            {
                nbCombats = value;
            }
        }

        public void demenager(string nouvelleAdresse)
        {
            adresse = nouvelleAdresse;
        }

        public void seBattre()
        {
            nbCombats++;
        }

        public void afficher()
        {
            Console.WriteLine("Nom : " + nom + " | Adresse : "+ adresse + " | Fonction : " + fonction + " | Nb combats : " + nbCombats + " | Arme : " + arme + " | Potion : "+ potion + " | Force " + force + " | Nombre de victoire : " + nbVictoire + " | Puissance : " + Puissance());
        }

        public int Puissance()
        {
            int calcul = 0;

            // Le personnage concerné a une potion
            if (potion != true)
            {
                // On compare l'arme du joueur par rapport à celles disponibles
                if (arme == "Glaives") 
                {
                    calcul = force + 10;
                }

                else if (arme == "Poings") // Poings
                {
                    calcul = force + 3;
                }

                else // Lance
                {
                    calcul = force + 15;
                }
            }

            else
            {
                // Le personnage n'a pas de potion
                if (arme == "Glaives") // Glaives
                {
                    calcul = force * 10 + 10;
                }
                
                else if (arme == "Poings") // Poings
                {
                    calcul = force * 10 + 3;
                }

                else // Lance
                {
                    calcul = force * 10  + 15;
                }
            }
            return calcul;
        }

        public string Duel(Personnage personnage1, Personnage personnage2)
        {
            int power_pers1 = personnage1.Puissance();
            int power_pers2 = personnage2.Puissance();

            nbCombats++;

            if (power_pers1 > power_pers2)
            {
                nbVictoire++;
                return personnage1.Nom;
            }

            else
            {
                nbVictoire++;
                return personnage2.Nom;
            }
        }
    }
}
