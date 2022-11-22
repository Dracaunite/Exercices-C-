using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMoyenneEleve
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définitions des variables
            String nomEleve;
            int intValeur, cpt, somme = 0, moyenne;

            // Saisie des variables
            Console.Write("Saisie du nom de l'élève : ");
            nomEleve = Console.ReadLine();
            Console.Write("Saisie du nombre de note : ");
            cpt = int.Parse(Console.ReadLine()); // Limite du compteur

            // Boucle
            for (int i = 1; i <= cpt; i++)
            {
                Console.Write("Saisie de la note N°" + i + " : ");
                intValeur = int.Parse(Console.ReadLine());
                somme += intValeur;

                if (i == cpt)
                {
                    moyenne = somme / i;
                    Console.WriteLine("Moyenne de "+nomEleve+" : "+ moyenne);
                }
            }
            Console.ReadKey();
        }
    }
}
