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
            Console.WriteLine("Nom : " + nom + " | adresse : "+ adresse + " | fonction : " + fonction + " | nb combats : " + nbCombats);
        }

        public void Puissance()
        {
            string[] tabArmes = new string[] { "Glaives", "Poings", "Lance" };
            int calcul = 0;

            for (int i = 0; i < 3; i++)
            {
                // Le personnage concerné a une potion
                if (potion != true)
                {
                    // On compare l'arme du joueur par rapport à celles disponibles
                    if (tabArmes[i] == tabArmes[0]) // Glaives
                    {
                        calcul = force + 10;
                        Console.WriteLine("Il possède des glaives.");
                    }

                    if (tabArmes[i] == tabArmes[1]) // Poings
                    {
                        calcul = force + 3;
                        Console.WriteLine("Il possède des poings.");
                    }

                    else // Lance
                    {
                        calcul = force + 15;
                        Console.WriteLine("Il possède une lance.");
                    }
                }

                else
                {
                    // Le personnage n'a pas de potion
                    if (tabArmes[i] == tabArmes[0]) // Glaives
                    {
                        calcul = force * 10 + 10;
                        Console.WriteLine("Il possède des glaives.");
                    }

                    if (tabArmes[i] == tabArmes[1]) // Poings
                    {
                        calcul = force * 10 + 3;
                        Console.WriteLine("Il possède des poings.");
                    }

                    else // Lance
                    {
                        calcul = force * 10  + 15;
                        Console.WriteLine("Il possède une lance.");
                    }
                }
            }
            Console.Write("La puissance d'Asterix est de : " + calcul);
        }
    }
}
