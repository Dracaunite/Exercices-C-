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
            // On définit la force + potion aléatoirement
            Random rnd = new Random();
            var randomBool_pers1 = rnd.Next(2) == 1; // 0 = false, 1 = true
            var randomBool_pers2 = rnd.Next(2) == 1;
            int force_pers1 = rnd.Next(5, 200);
            int force_pers2 = rnd.Next(5, 200);

            // Mise en place attribut 
            Personnage asterix = new Personnage("Asterix", "Village des Gaulois", "Guerrier", 199, "Poings", randomBool_pers1, force_pers1, 150);
            Personnage romain = new Personnage("Romain", "Rome", "Soldat", 50, "Lance", randomBool_pers2, force_pers2, 1);

            // Application des changements sur objet Asterix
            asterix.afficher();
            asterix.demenager("Rome");
            asterix.seBattre();
            Console.WriteLine("--- Valeurs d'Asterix après un déménagement et un combat ---");
            Console.WriteLine("Nouvelle adresse : " + asterix.Adresse);
            Console.WriteLine("Nouveau nombre de combats : " + asterix.NbCombats);
            asterix.Adresse = "Village des Gaulois";
            Console.WriteLine("Adresse remise initialement : " + asterix.Adresse);

            // Idem pour objet Romain
            romain.afficher();
            romain.demenager("Village des Gaulois");
            romain.seBattre();
            Console.WriteLine("--- Valeurs du Romain après un déménagement et un combat ---");
            Console.WriteLine("Nouvelle adresse : " + romain.Adresse);
            Console.WriteLine("Nouveau nombre de combats : " + romain.NbCombats);
            asterix.Adresse = "Rome";
            Console.WriteLine("Adresse remise initialement : " + romain.Adresse);


            // Exercices (Duel + Puissance)
            Console.WriteLine(asterix.Duel(asterix, romain) + " gagne ");

            Console.ReadKey();
        }
    }
}
