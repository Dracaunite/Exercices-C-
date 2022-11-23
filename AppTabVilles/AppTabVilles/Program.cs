using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTabVilles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisation du tableau
            string[] tabVilles = new string[] { "Paris", "Marseille", "Lyon", "Deauville", "Lorient", "Brest", "Lille", "Bordeaux" };

            // Gestion d'erreur
            for (int i = 0; i <= 7; i++)
            {
                // Utilisateur rentre un numéro, affiche la ville attribué au numéro.
                if (i <= 7)
                {
                    break;
                }

                else
                {
                    Console.Write("Numéro incorrect, recommencer la saisie !");
                }
            }
        }
    }
}
