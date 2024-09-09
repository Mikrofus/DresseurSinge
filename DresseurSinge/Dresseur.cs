using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DresseurSinge
{
    public class Dresseur
    {
        public string Nom { get; private set; }
        public Singe Singe { get; private set; }

        public Dresseur(string nom, Singe singe)
        {
            Nom = nom;
            Singe = singe;
        }

        public void DemanderTour(Tour tour)
        {
                Console.WriteLine($"{Nom} demande à {Singe.Nom} d'exécuter le tour : {tour.Nom}");
                Singe.ExecuterTour(tour);
        }

        public string GetNomSinge()
        {
            return Singe.Nom;
        }
    }
}
