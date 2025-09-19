using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public class Mootorratas : ISõiduk
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public Mootorratas(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public double ArvutaKulu()
        {
            if (Vanus < 5) return 3.0;
            else if (Vanus <= 10) return 2.0;
            else return 1.0;
        }
        public double ArvutaVahemaa()
        {
            return 100.0;
        }
        public override string ToString()
        {
            return $"Mootorratas: {Nimi}, Vanus: {Vanus}, Kulu: {ArvutaKulu():F2} EUR";
        }
    }
}
