using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public class Elektritõukeratas : ISõiduk
    {
        public double AkuKuluKwh100km { get; }
        public double Km { get; }

        public Elektritõukeratas(double akuKuluKwh100km, double km)
        {
            AkuKuluKwh100km = akuKuluKwh100km;
            Km = km;
        }

        public double ArvutaKulu() => (AkuKuluKwh100km / 100.0) * Km;
        public double ArvutaVahemaa() => Km;
        public override string ToString()
        {
            return $"Elektritõukeratas: {Km} km, akukulu {AkuKuluKwh100km} kWh/100km";
        }
    }
}
