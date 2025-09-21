using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public class Buss : ISõiduk
    {
        public double Kütusekulu { get; set; }
        public double Km { get; set; }
        public int ReisijateArv { get; set; }
        public Buss(double kütusekulu, double km, int reisijateArv)
        {
            Kütusekulu = kütusekulu;
            Km = km;
            ReisijateArv = reisijateArv;
        }
        public double ArvutaKulu() => ((Kütusekulu / 100) * Km) / ReisijateArv;
        public double ArvutaVahemaa() => Km;
        public override string ToString()
        {
            return $"Buss: {Km} km, kütusekulu {Kütusekulu} l/100km, reisijaid {ReisijateArv}";
        }
    }
}
