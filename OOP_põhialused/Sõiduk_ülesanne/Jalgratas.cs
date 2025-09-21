using OOP_põhialused;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    internal class Jalgratas : ISõiduk
    {
        public double Km { get; }
        public Jalgratas(double km)
        {
            Km = km;
        }
        public double ArvutaKulu() => 0.0; 
        public double ArvutaVahemaa() => Km;
        public override string ToString()
        {
            return $"Jalgratas: {Km} km, kütusekulu 0";
        }
    }
}
