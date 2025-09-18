using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    public class Loomad
    {
        public string Nimi;
        public int Vanus;
        public Loomad() { }
        public Loomad(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Tervita() //действие
        {
            Console.WriteLine("Tere! See on: " + Nimi);
        }
    }
    //доделать
    public class Liinud : Loomad
    {
        public string Liik = "Kass";

        public void Liiki()
        {
            Console.WriteLine($"{Nimi} linnu tõug on {Liik}.");
        }
    }
    public class Imetajad : Loomad
    {
        public string Liik = "Koer";
        public void Liikid()
        {
            Console.WriteLine($"{Nimi} imetaja tõug on {Liik}.");
        }
    }
}
