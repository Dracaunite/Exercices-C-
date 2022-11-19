using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculette
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définition des variables
            String strValeur1, strValeur2, op;
            float floatValeur1, floatValeur2, resultat;

            Console.WriteLine("--------------------------------");        
            Console.WriteLine("|       Mini Calculatrice      |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|     Opérations Possibles     |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("|        Addition :       A    |");
            Console.WriteLine("|        Soustraction :   S    |");
            Console.WriteLine("|        Multiplication : M    |");
            Console.WriteLine("|        Division :       D    |");
            Console.WriteLine("--------------------------------");
            Console.Write("Choix opération : ");
            op = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            // Entrée des valeurs
            Console.Write("Saissisez la première valeur : ");
            strValeur1 = Console.ReadLine();
            Console.Write("Saissisez la seconde valeur : ");
            strValeur2 = Console.ReadLine();
            Console.WriteLine("--------------------------------");

            // Conversion des variables
            floatValeur1 = float.Parse(strValeur1);
            floatValeur2 = float.Parse(strValeur2);

            switch (op)
            {
                case "A" :
                    resultat = floatValeur1 + floatValeur2;
                    Console.Write(floatValeur1+" + "+floatValeur2+" = "+resultat);
                    break;


                case "S":
                    resultat = floatValeur1 - floatValeur2;
                    Console.Write(floatValeur1 + " - " + floatValeur2 + " = " + resultat);
                    break;


                case "M":
                    resultat = floatValeur1 * floatValeur2;
                    Console.Write(floatValeur1 + " x " + floatValeur2 + " = " + resultat);
                    break;

                case "D":
                    if (floatValeur1 == 0 || floatValeur2 == 0)
                    {
                        Console.Write("La divison par zéro est impossible.");
                    }

                    else
                    {
                        resultat = floatValeur1 / floatValeur2;
                        Console.WriteLine(floatValeur1 + " / " + floatValeur2 + " = " + resultat);
                        Console.Write("Division entière : "+resultat+ " Reste : "+floatValeur1 % floatValeur2);  // Division entière marche pas

                    }
                    break;

                default:
                    Console.Write("Je connais pas cette opération.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
