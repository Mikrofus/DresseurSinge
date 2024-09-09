using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DresseurSinge
{
    public class Tour
    {
        public string Nom { get; private set; }
        public string Type { get; private set; } // "acrobatie" ou "musique"

        public Tour(string nom, string type)
        {
            Nom = nom;
            Type = type;
        }
    }
}
