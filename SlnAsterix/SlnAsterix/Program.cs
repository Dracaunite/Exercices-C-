using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnAsterix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mise en place attribut 
            Personnage asterix = new Personnage("Asterix", "Village des Gaulois", "Guerrier", 199, "Poings", true, 12, 150);
            Personnage romain  = new Personnage("Romain", "Rome", "Soldat", 50, "Lance", false, 25, 1);

            // Application des changements sur objet Asterix
            asterix.afficher();
            asterix.demenager("Rome");
            asterix.seBattre();
            Console.WriteLine("--- Valeurs d'Asterix après un déménagement et un combat ---");
            Console.WriteLine("Nouvelle adresse : " + asterix.Adresse);
            Console.WriteLine("Nouveau nombre de combats : " + asterix.NbCombats);
            asterix.Adresse = "Village des Gaulois";
            Console.WriteLine("Adresse remise initialement : " + asterix.Adresse);

            romain.afficher();
            romain.demenager("Village des Gaulois");
            romain.seBattre();
            Console.WriteLine("--- Valeurs du Romain après un déménagement et un combat ---");
            Console.WriteLine("Nouvelle adresse : " + romain.Adresse);
            Console.WriteLine("Nouveau nombre de combats : " + romain.NbCombats);
            asterix.Adresse = "Rome";
            Console.WriteLine("Adresse remise initialement : " + romain.Adresse);


            // Exercices
            asterix.Puissance();
            romain.Puissance();
            Console.WriteLine(asterix.Duel(asterix.Nom, romain.Nom) + " gagne ");

            Console.ReadKey();
        }
    }
}
