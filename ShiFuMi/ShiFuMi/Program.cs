﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiFuMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choixJoueur, choixOrdi, scoreJoueur = 0, scoreOrdi = 0, manche = 0;
            Random aleatoire = new Random();

            Console.WriteLine("##################################");
            Console.WriteLine("# \t Shi \t Fu \t Mi \t #");
            Console.WriteLine("##################################");

            do
            {
                manche++;

                Console.WriteLine("0 - Quitter");
                Console.WriteLine("1 - Pierre");
                Console.WriteLine("2 - Feuille");
                Console.WriteLine("3 - Ciseaux");

                Console.Write("Votre choix : ");
                choixJoueur = int.Parse(Console.ReadLine());
                choixOrdi = aleatoire.Next(1, 4);

                // Gestion des cas d'erreur
                if (choixJoueur == 0)
                {
                    // Si on rentre valeur 0 (quitter le jeu) la console se ferme.
                    Environment.Exit(0);
                }

                do
                {
                    // Si on rentre valeur > 3 (valeur inconnue)
                    if (choixJoueur > 3)
                    {
                        Console.WriteLine("Erreur, vous devez saisir une valeur entre 1 et 3.");
                        Console.Write("Votre choix : ");
                        choixJoueur = int.Parse(Console.ReadLine());
                    }
                }
                while (choixJoueur > 3);
                    
                Console.WriteLine("Choix de l'ordinateur : " + choixOrdi);

                // Pierre vs Ciseaux
                if (choixJoueur == 1 && choixOrdi == 3)
                {
                    Console.WriteLine("Vous avez gagné !");
                    scoreJoueur++;
                }

                // Feuille vs Pierre
                else if (choixJoueur == 2 && choixOrdi == 1)
                {
                    Console.WriteLine("Vous avez gagné");
                    scoreJoueur++;
                }

                // Ciseaux vs Feuille
                else if (choixJoueur == 3 && choixOrdi == 2)
                {
                    Console.WriteLine("Vous avez gagné");
                    scoreJoueur++;
                }

                // Cas d'égalité
                else if (choixJoueur == choixOrdi)
                {
                    Console.WriteLine("C'est une manche nulle.");
                }
                
                // Cas de défaites
                else
                {
                    Console.WriteLine("Vous avez perdu !");
                    scoreOrdi++;
                }

                Console.WriteLine("Manche " + manche + " \t \t Scores : \n \t Vous :  " + scoreJoueur + " \t Ordinateur : " + scoreOrdi);
            }
            while (choixJoueur != 0);

            Console.ReadKey();
        }
    }
}
