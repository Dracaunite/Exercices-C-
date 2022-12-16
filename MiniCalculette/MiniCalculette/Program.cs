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
            String op;
            float floatValeur1, floatValeur2, resultat;

            Console.WriteLine("----------------------------------------");        
            Console.WriteLine("|           Mini Calculatrice          |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|          Opérations Possibles        |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|            Addition :       A        |");
            Console.WriteLine("|            Soustraction :   S        |");
            Console.WriteLine("|            Multiplication : M        |");
            Console.WriteLine("|            Division :       D        |");
            Console.WriteLine("----------------------------------------");

            Console.Write("Informer le type d'opération : ");
            op = Console.ReadLine();

            switch (op)
            {
                case "A" :
                    Console.Write("Saissisez la première valeur : ");
                    floatValeur1 = float.Parse(Console.ReadLine());
                    Console.Write("Saissisez la seconde valeur : ");
                    floatValeur2 = float.Parse(Console.ReadLine());
                    resultat = floatValeur1 + floatValeur2;
                    Console.Write("Le résultat de cette addition est : " + resultat);
                    break;

                case "S":
                    Console.Write("Saissisez la première valeur : ");
                    floatValeur1 = float.Parse(Console.ReadLine());
                    Console.Write("Saissisez la seconde valeur : ");
                    floatValeur2 = float.Parse(Console.ReadLine());
                    resultat = floatValeur1 - floatValeur2;
                    Console.Write("Le résultat de cette soustraction est : " + resultat);
                    break;


                case "M":
                    Console.Write("Saissisez la première valeur : ");
                    floatValeur1 = float.Parse(Console.ReadLine());
                    Console.Write("Saissisez la seconde valeur : ");
                    floatValeur2 = float.Parse(Console.ReadLine());
                    resultat = floatValeur1 * floatValeur2;
                    Console.Write("Le résultat de cette multiplication est : " + resultat);
                    break;

                case "D":
                    do
                    {
                        Console.Write("Saissisez la première valeur : ");
                        floatValeur1 = float.Parse(Console.ReadLine());
                        Console.Write("Saissisez la seconde valeur : ");
                        floatValeur2 = float.Parse(Console.ReadLine());

                        // Une des deux valeurs est égale à 0
                        if (floatValeur1 == 0 || floatValeur2 == 0)
                        {
                            Console.WriteLine("Erreur: Le dividende ne peut pas étre egal zéro");
                        }
                    }
                    while (floatValeur1 == 0 || floatValeur2 == 0);

                    resultat = floatValeur1 / floatValeur2;
                    Console.Write("Le résultat de cette division est : " + resultat);
                    break;
            }

            Console.ReadKey();
        }
    }
}
