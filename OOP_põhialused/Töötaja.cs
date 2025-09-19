using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public class Töötaja : Inimene
    {
        public string Ametikoht = "Keevitaja";
        public double Tunnitasu = 15.50;
        public int Tunnid { get; set; }

        public void Töötan()
        {
            Console.WriteLine($"{Nimi} töötab ametikohal {Ametikoht}.");
        }
        public override void Mida_tee()
        {
            Console.WriteLine($"{Nimi} töötan töö");
        }
        public double ArvutaPalk()
        {
            return Tunnitasu * Tunnid;
        }  
    }
}
