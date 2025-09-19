using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public class Auto : ISõiduk
    {
        public double Kütusekulu { get; set; } // liitrites 100 km kohta
        public double Km { get; set; } // läbitud vahemaa km
        public Auto(double kütusekulu, double km) 
        {
            Kütusekulu = kütusekulu; 
            Km = km;
        }
        public double ArvutaKulu() => (Kütusekulu / 100) * Km; // kulu liitrites
        public double ArvutaVahemaa() => Km; // vahemaa km
    }
}
