using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom;
            int nJour, nMois, nAnnee, age;

            // Date systeme (aujourd'hui)
            DateTime uneDate = DateTime.Now;
            int jour = uneDate.Day;
            int mois = uneDate.Month;
            int annee = uneDate.Year;

            Console.Write("Donnez votre prénom : ");
            prenom = Console.ReadLine();
            Console.Write("Donnez votre jour de naissance JJ : ");
            nJour = int.Parse(Console.ReadLine());
            Console.Write("Donnez votre mois de naissance MM : ");
            nMois = int.Parse(Console.ReadLine());
            Console.Write("Donnez votre annéee de naissance AAAA : ");
            nAnnee= int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------");

            age = annee - nAnnee;

            // Si le mois en cours < mois de naissance
            if (mois < nMois)
            {
                // On soustrait l'âge par 1
                age = annee - nAnnee - 1;
            }

            // Si le mois de naissance = mois actuel et jour actuel < jour de naissance
            else if (mois == nMois && jour < nJour)
            {
                // On soustrait l'âge par 1
                age = annee - nAnnee - 1;
            }

            Console.WriteLine("Date d'aujourd'hui : " + jour + "/" + mois + "/" + annee);
            Console.Write("Bonjour " + prenom + ", vous avez " + age + " ans. ");
            Console.ReadKey();
        }
    }
}
