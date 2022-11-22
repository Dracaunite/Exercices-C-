using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMoyenneTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définitions des variables
            int intValeur, somme = 0, moyenne;

            // Boucle
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("Saisie de la note N°"+i+" : ");
                intValeur = int.Parse(Console.ReadLine());
                somme += intValeur;

                if (i == 6)
                {
                    moyenne = somme / i;
                    Console.WriteLine("Moyenne : " + moyenne);
                }
            }
            Console.ReadKey();
        }
    }
}
