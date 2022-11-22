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
            float floatValeur1;
            float floatValeur2;
            float resultat;

            Console.WriteLine("------------------------------");        
            Console.WriteLine("|      Mini Calculatrice     |");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|    Opérations Possibles |   ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|       Addition :       A   |");
            Console.WriteLine("|       Soustraction :   S   |");
            Console.WriteLine("|       Multiplication : M   |");
            Console.WriteLine("|       Division :       D   |");
            Console.WriteLine("------------------------------");

            Console.Write("Informer le type d'opération: ");
            op = Console.ReadLine();

            switch (op)
            {
                case "A" :
                    Console.Write("Saissisez la premiere valeur: ");
                    strValeur1 = Console.ReadLine();
                    Console.Write("Saissisez la seconde valeur: ");
                    strValeur2 = Console.ReadLine();
                    r = valeur1 + valeur2;
                    Console.Write("Le résultat de cette addition est : " + r );
                   break;


                case "S":
                    Console.Write("Saissisez la premiere valeur: ");
                    strValeur1 = Console.ReadLine();
                    Console.Write("Saissisez la seconde valeur: ");
                    strValeur2 = Console.ReadLine();
                    r = valeur1 - valeur2;
                    Console.Write("Le résultat de cette soustraction est : " + r);
                    break;


                case "M":
                    Console.Write("Saissisez la premiere valeur: ");
                    strValeur1 = Console.ReadLine();
                    Console.Write("Saissisez la seconde valeur: ");
                    strValeur2 = Console.ReadLine();
                    resultat = valeur1 * valeur2;
                    Console.Write("Le résultat de cette multiplication est : " + r);
                    break;

                case "D":
                    Console.Write("Saissisez la premiere valeur: ");
                    strValeur1 = Console.ReadLine();
                    Console.Write("Saissisez la seconde valeur: ");
                    strValeur2 = Console.ReadLine();
                    valeur1 = float.Parse(strValeur1);
                    valeur2 = float.Parse(strValeur2);
                    while (valeur2 == 0)
                    {
                        Console.WriteLine("Erreur: Le dividande ne peut pas étre egal zéro");       // Pour verifier si la valeur n'est pas égale a zéro
                        Console.Write("Saissisez la premiere valeur: ");
                        strValeur1 = Console.ReadLine();
                        Console.Write("Saissisez la seconde valeur: ");
                        strValeur2 = Console.ReadLine();
                        valeur1 = float.Parse(strValeur1);
                        valeur2 = float.Parse(strValeur2);
                    }

                    r = valeur1 / valeur2;
                    Console.Write("Le résultat de cette division est : " + r);
                    break;
            }

            Console.ReadKey();
        }
    }
}
