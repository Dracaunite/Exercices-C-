using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTableMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définition des variables
            String strValeur;
            int intValeur;

            // Saisi de la variable
            Console.Write("Choisissez la table de multiplication souhaitée : ");
            intValeur = int.Parse(Console.ReadLine());

            // Début de la boucle
            for (int i = 1; i <= 10; i++) // i allant de 0 à 9 (1 à 10)
            {
                Console.WriteLine(intValeur+" x "+i+" = "+intValeur*i);
            }
            Console.ReadKey();
        }
    }
}