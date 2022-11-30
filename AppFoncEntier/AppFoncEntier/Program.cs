using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFoncEntier
{
    class Program
    {
        public static int SaisieEntier()
        {
            // Variables locales
            int valeur;
            string strValeur;

            // La boucle s'arrête pas tant que la conversion str en int n'est pas possible ou valeur dépasse 255.
            do
            {
                Console.Write("Saisir un nombre entier : ");
                strValeur = Console.ReadLine();
            } while (int.TryParse(strValeur, out valeur) == false);

            // Sortie de boucle (condition vraie)
            valeur = int.Parse(strValeur);

            // Si la valeur dépasse 255 on revient dans la boucle
            if (valeur > 255)
            {
                Console.WriteLine("Veuillez saisir un entier compris entre 0 et 255.");
            }

            // Sinon on renvoit la valeur
            return valeur;
        }
        static void Main(string[] args)
        {
            // Code
            Console.WriteLine("Valeur saisie : "+SaisieEntier());

            Console.ReadKey();
        }
    }
}
