using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoncMin
{
    class Program
    {
        /// <summary>
        /// Cette fonction retourne le nombre le plus petit parmis 3 nombres distincts.
        /// </summary>
        /// <param name="nb1">Premier nombre en entier</param>
        /// <param name="nb2">Deuxième nombre en entier</param>
        /// <param name="nb3">Troisième nombre en entier</param>
        /// <returns>Le nombre le plus petit</returns>
        public static int NombreMini(int nb1, int nb2, int nb3)
        {
            int mini;

            if (nb1 > nb2)
            {
                mini = nb2;
            }

            else
            {
                mini = nb1;
            }

            if (nb2 > nb3)
            {
                mini = nb3;
            }
            
            return mini;
        }

        static void Main(string[] args)
        {
            // Variables
            int nombre1, nombre2, nombre3;

            // Code
            Console.Write("Saisir un entier : ");
            nombre1 = int.Parse(Console.ReadLine());

            Console.Write("Saisir un deuxième entier : ");
            nombre2 = int.Parse(Console.ReadLine());

            Console.Write("Saisir un troisième entier : ");
            nombre3 = int.Parse(Console.ReadLine());

            Console.Write("L'entier le plus petit est : "+NombreMini(nombre1, nombre2, nombre3));

            Console.ReadKey();
        }
    }
}
