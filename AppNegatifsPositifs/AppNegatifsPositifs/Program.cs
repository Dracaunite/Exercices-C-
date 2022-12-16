using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNegatifsPositifs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb, calculNegatifs = 0, compteur_pos = 0;
            float calculPositifs = 0;

            do
            {
                Console.Write("Saisir un nombre < 0 pour arrêter la saisie > : ");
                nb = int.Parse(Console.ReadLine());

                if (nb > 0)
                {
                    calculPositifs = calculPositifs + nb;
                    compteur_pos++;
                }

                else if (nb < 0)
                {
                    calculNegatifs = calculNegatifs + nb;
                }
            }
            while (nb != 0);

            // Moyenne des nombres positifs
            calculPositifs = calculPositifs / compteur_pos;

            Console.WriteLine("----- 0 a été saisi --> Arrêt de la boucle -----");
            Console.WriteLine("Moyenne des nombres positifs : " + calculPositifs);
            Console.Write("Somme des nombres négatifs : " + calculNegatifs);

            Console.ReadKey();
        }
    }
}
