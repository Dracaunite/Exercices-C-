using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProduitTab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des tableaux
            int[] tab1 = new int[] { 4, 8, 7, 9, 1, 5, 4, 6 };
            int[] tab2 = new int[] { 7, 6, 5, 2, 1, 3, 7, 4 };
            int[] tabResultat = new int[8]; // tableau vide

            // Calculs et remplissage du tableau
            for (int i = 0; i <= 7; i++)
            {
                tabResultat[i] = tab1[i] * tab2[i];
                Console.Write(tabResultat[i]+" \t ");
            }
            Console.ReadKey();
        }
    }
}
