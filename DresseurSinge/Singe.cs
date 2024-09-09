using DresseurSinge;
using System;
using System.Collections.Generic;

namespace DresseurSinge 
{ 
    public class Singe
    {
        public string Nom { get; private set; }
        private List<Tour> tours;

        public Singe(string nom)
        {
            Nom = nom;
            tours = new List<Tour>();
        }

        // Méthode pour exécuter un tour
        public void ExecuterTour(Tour tour)
        {
            Console.WriteLine($"{Nom} exécute le tour : {tour.Nom}");
        }

        public void AddTour(Tour tour)
        {
            tours.Add(tour);
        }

        public List<Tour> GetTours()
        {
            return tours;
        }
    }
}
