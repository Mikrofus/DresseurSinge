using System;

namespace DresseurSinge
{
    public class Spectateur
    {
        public string Nom { get; private set; }

        public Spectateur(string nom)
        {
            Nom = nom;
        }

        public void Reagir(Tour tour, string nomSinge)
        {
            if (tour.Type == "acrobatie")
            {
                Console.WriteLine($"{Nom} applaudit pendant le tour d'acrobatie '{tour.Nom}' du singe {nomSinge}");
            }
            else if (tour.Type == "musique")
            {
                Console.WriteLine($"{Nom} siffle pendant le tour de musique '{tour.Nom}' du singe {nomSinge}");
            }
            else
            {
                Console.WriteLine($"{Nom} ne reagit pas pendant le tour '{tour.Nom}' du singe {nomSinge}");
            }
        }
    }
}
