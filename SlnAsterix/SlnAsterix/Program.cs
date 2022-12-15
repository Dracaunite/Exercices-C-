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
            Personnage asterix = new Personnage("Asterix", "Grande Rue", "Lance", 10, "Lance", false, 12, 1);
            
            // Application des changements sur objet Asterix
            asterix.afficher();
            asterix.demenager("Rome");
            asterix.seBattre();
            Console.WriteLine("--- Valeurs d'Asterix après un déménagement et un combat ---");
            Console.WriteLine("Nouvelle adresse : " + asterix.Adresse);
            Console.WriteLine("Nouveau nombre de combats : " + asterix.NbCombats);
            asterix.Adresse = "Grande Rue";
            Console.WriteLine("Adresse remise initialement : " + asterix.Adresse);

            // Exercices
            asterix.Puissance();

            // Console.WriteLine(asterix.Nom+" possède une puissance de : "+ asterix.Puissance());

            Console.ReadKey();
        }
    }
}
