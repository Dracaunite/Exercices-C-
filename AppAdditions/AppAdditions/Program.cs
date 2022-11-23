using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdditions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création de 2 boucles : 1) afficher la table d'addition qui va être calculée, 2) résultats de la table d'additions effectués.
            for (int i = 0; i <= 9; i++)
            {
                Console.Write(i+" \t ");

                for (int j = 0; j <= 9; j++)
                {
                    Console.Write((i+j)+ " \t ");
                }
                Console.WriteLine(); // saute une ligne après avoir fait addition de la table concernée
            }
            Console.ReadKey();
        }
    }
}
