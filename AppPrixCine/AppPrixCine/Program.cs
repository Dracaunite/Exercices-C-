using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPrixCine
{
    class Program
    {
        static void Main(string[] args)
        {
            // definition du type de variables
            String AgePerso1, AgePerso2;
            int intAgePerso1;
            int intAgePerso2;

            // Saisie des valeurs
            Console.Write("Saisir l'âge de la première personne : ");
            AgePerso1 = Console.ReadLine();

            Console.Write("Saisir l'âge de la deuxième personne : ");
            AgePerso2 = Console.ReadLine();

            // Conversion en int
            intAgePerso1 = int.Parse(AgePerso1);
            intAgePerso2 = int.Parse(AgePerso2);

            // Conditions
            if (intAgePerso1 < 18 && intAgePerso2 < 18)
            {
                Console.Write("Vous devez payer 14€.");
            }

            else if (intAgePerso1 >= 18 || intAgePerso2 >= 18)
            {
                Console.Write("Vous devez payer 18€.");
            }

            else
            {
                Console.Write("Vous devez payer 15€.");
            }

            Console.ReadLine();
        }
    }
}
