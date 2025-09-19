using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public abstract class Loomad
    {
        public string Nimi;
        public int Vanus;
        public string Liik;

        public Loomad() { }
        public Loomad(string nimi, int vanus, string liik)
        {
            Nimi = nimi;
            Vanus = vanus;
            Liik = liik;
        }

        public void Tervita() //действие
        {
            Console.WriteLine("Tere! See on: " + Nimi);
        }
        public abstract void TeeHääl();
        public abstract void Tee();
        public abstract void Sööma();
    }
    //доделать
    public class Koer : Loomad
    {
        public override void TeeHääl()
        {
            Console.WriteLine("Auh - auh!");
        }

        public override void Tee()
        {
            Console.WriteLine("Koer jookseb aeda.");
        }

        public override void Sööma()
        {
            Console.WriteLine("Koer sööb luud.");
        }
    }

    public class Linnud : Loomad
    {
        public override void TeeHääl()
        {
            Console.WriteLine("Kräu - kräu!");
        }

        public override void Tee()
        {
            Console.WriteLine("Lind lendab kõrgele.");
        }

        public override void Sööma()
        {
            Console.WriteLine("Lind sööb seemneid.");
        }
    }
    public class Kala : Loomad
    {
        public override void TeeHääl()
        {
            Console.WriteLine("Blub blub!"); 
        }

        public override void Tee()
        {
            Console.WriteLine("Kala ujub veekogus.");
        }

        public override void Sööma()
        {
            Console.WriteLine("Kala sööb vetikaid või väikseid kalu.");
        }
    }
}
