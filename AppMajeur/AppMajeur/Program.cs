using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMajeur
{
    class Program
    {
        static void Main(string[] args)
        {
            // Définition du type de variable
            String age;
            int intAge;

            // Saisie de la valeur
            Console.Write("Saisissez votre âge : ");
            age = Console.ReadLine();

            // Conversion String en int
            intAge = int.Parse(age);

            // Mise en place de la condition
            if (intAge < 18)
            {
                Console.Write("Vous êtes une personne mineure.");
            }

            else if (intAge >= 18 && intAge < 65)
            {
                Console.Write("Vous êtes une personne majeure.");
            }

            else
            {
                Console.Write("Vous êtes une personne majeure et senior.");
            }

            // La fenêtre de la console reste ouverte
            Console.ReadKey();
        }
    }
}
