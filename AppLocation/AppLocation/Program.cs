using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLocation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dureeLocation, km;
            float tarifEssence, tarifDiesel;

            Console.Write("La durée de location : ");
            dureeLocation = int.Parse(Console.ReadLine());
            Console.Write("La distance à parcourir : ");
            km = int.Parse(Console.ReadLine());

            // Calculs
            tarifEssence = (float)((60 * dureeLocation) + (0.25 * km));
            tarifDiesel = (float)((70 * dureeLocation) + (0.20 * km));

            Console.WriteLine("Tarif essence : " + tarifEssence + "\nTarif diesel : " + tarifDiesel);

            if (tarifDiesel == tarifEssence)
            {
                Console.WriteLine("Choix : le prix d'une voiture essence et diesel est le même.");
            }

            if (tarifDiesel > tarifEssence)
            {
                Console.WriteLine("Choix : le prix d'une voiture essence est plus interéssant.");
            }

            else if (tarifDiesel < tarifEssence)
            {
                Console.WriteLine("Choix : le prix d'une voiture diesel est plus interéssant.");
            }

            Console.ReadKey();
        }
    }
}
