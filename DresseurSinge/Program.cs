using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DresseurSinge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'un spectateur
            Spectateur spectateur = new Spectateur("Valentin");

            // Création des 2 singes
            Singe singe1 = new Singe("Koko");
            Singe singe2 = new Singe("Bobo");

            // Ajout des tours aux singes
            singe1.AddTour(new Tour("Marcher sur les mains", "acrobatie"));
            singe1.AddTour(new Tour("Jouer de la guitare", "musique"));
            singe1.AddTour(new Tour("Faire un salto", "acrobatie"));

            singe2.AddTour(new Tour("Sauter à travers un cerceau", "acrobatie"));
            singe2.AddTour(new Tour("Battre des cymbales", "musique"));


            // Création de deux dresseurs avec leur singe
            Dresseur dresseur1 = new Dresseur("Paul", singe1);
            Dresseur dresseur2 = new Dresseur("Marie", singe2);

            // Dresseur 1 demande à son singe d'exécuter tous ses tours et le spectateur réagit
            foreach (var tour in singe1.GetTours())
            {
                dresseur1.DemanderTour(tour);
                spectateur.Reagir(tour, dresseur1.GetNomSinge());
                Console.WriteLine("-------------------------------------");
            }

            // Dresseur 2 demande à son singe d'exécuter tous ses tours et le spectateur réagit
            foreach (var tour in singe2.GetTours())
            {
                dresseur2.DemanderTour(tour);
                spectateur.Reagir(tour, dresseur2.GetNomSinge());
                Console.WriteLine("-------------------------------------");
            }

            Console.ReadLine();

        }
    }
}
