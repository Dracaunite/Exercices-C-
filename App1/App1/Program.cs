using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration des variables
            String strMontantHt;
            decimal montantHt;
            decimal montantTtc;
            decimal tva;

            // Affectation des variables
            tva = 0.2M;

            // Saisie du montant HT
            Console.Write("Saisir le montant HT : ");
            strMontantHt = Console.ReadLine();

            // Conversion de la chaine de caractère saisie en décimal
            montantHt = decimal.Parse(strMontantHt);

            // Calcul du montant TTC
            montantTtc = montantHt * (1 + tva);
            Console.Write("TVA : ");
            Console.WriteLine(tva);
            Console.Write("Montant TTC : ");
            Console.WriteLine(montantTtc);
            Console.ReadKey();
        }
    }
}
