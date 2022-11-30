using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoncTabMin
{
   class Program
   {
        /// <summary>
        /// La fonction permet de trouver l'entier le pus petit d'un tableau en le parcourant
        /// </summary>
        /// <param name="tabEnt">tableau de nombres entiers</param>
        /// <returns>L'entier le plus petit du tableau</returns>
        public static int unMinimumTab(int[] tabEnt)
        {
            int tabMin = tabEnt[0];

            // Parcourt le tableau (1 à 10 -> 0 à 9)
            for (int i = 0; i < 9; i++)
            {
                // Si nombre du tableau est plus petit que le nombre du tableau "statique"
                if (tabEnt[i] < tabMin)
                {
                    // On affecte valeur du nombre plus petit à tabMin
                    tabMin = tabEnt[i];
                }
            }

            return tabMin;
        }
        static void Main(string[] args)
        {
            // Variable
            int[] tabEntiers = new int[] { 12, 8, 15, 10, 18, 7, 20, 2, 9, 19 };

            // Code
            Console.Write("L'entier le plus petit du tableau est : " + unMinimumTab(tabEntiers));

            Console.ReadKey();
        }
    }
}
