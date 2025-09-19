using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public abstract class Inimene
    {
        public string Nimi;
        public int Vanus;
        public Pank KontoPank {  get; set; }
        public Inimene() 
        {
            KontoPank = new Pank();
        }
        public Inimene(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
            KontoPank = new Pank();
        }

        public void Tervita() //действие
        {
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }
        public abstract void Mida_tee();
    }
}
