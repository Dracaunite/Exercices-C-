using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSomme
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definition type de variables
            String valeur1, valeur2;
            int intValeur1;
            int intValeur2;
            int resultat;

            // Saisie des nombres
            Console.Write("Entrez le premier nombre : ");
            valeur1 = Console.ReadLine();

            Console.Write("Entrez le second nombre : ");
            valeur2 = Console.ReadLine();

            // Conversion str en int
            intValeur1 = int.Parse(valeur1);
            intValeur2 = int.Parse(valeur2);

            // Calcul
            resultat = intValeur1 + intValeur2;

            // Affichage du résultat
            Console.WriteLine("Vous avez saisi : " + intValeur1 + " et " + intValeur2);
            Console.Write("Le résultat est le suivant : " + intValeur1 + " + " + intValeur2 + " = ");
            Console.WriteLine(resultat);
            Console.ReadKey();
            
        }
    }
}
