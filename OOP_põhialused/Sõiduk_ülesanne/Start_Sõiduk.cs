using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    internal class Start_Sõiduk
    {
        public static void Main(string[] args)
        {
            try
            { 
                    List<ISõiduk> sõidukid = new List<ISõiduk>();
                while (true)
                {
                    Console.WriteLine("Vali sõiduk: 1=Auto, 2=Jalgratas, 3=Buss, 4=Mootorratas, 0=Välju");
                    string valik = Console.ReadLine();
                    if (valik == "0") break;
                    switch (valik)
                    {
                        case "1":
                            Console.Write("Sisesta kütusekulu (liitrites 100 km kohta): ");
                            double autoKütusekulu = double.Parse(Console.ReadLine());
                            Console.Write("Sisesta läbitud vahemaa (km): ");
                            double autoKm = double.Parse(Console.ReadLine());
                            sõidukid.Add(new Auto(autoKütusekulu, autoKm));
                            break;
                        case "2":
                            Console.Write("Sisesta läbitud vahemaa (km): ");
                            double jalgratasKm = double.Parse(Console.ReadLine());
                            sõidukid.Add(new Jalgratas(jalgratasKm));
                            break;
                        case "3":
                            Console.Write("Sisesta kütusekulu (liitrites 100 km kohta): ");
                            double bussKütusekulu = double.Parse(Console.ReadLine());
                            Console.Write("Sisesta läbitud vahemaa (km): ");
                            double bussKm = double.Parse(Console.ReadLine());
                            Console.Write("Sisesta reisijate arv: ");
                            int reisijateArv = int.Parse(Console.ReadLine());
                            sõidukid.Add(new Buss(bussKütusekulu, bussKm, reisijateArv));
                            break;
                        case "4":
                            Console.Write("Sisesta mootorratta nimi: ");
                            string nimi = Console.ReadLine();
                            Console.Write("Sisesta mootorratta vanus (aastates): ");
                            int vanus = int.Parse(Console.ReadLine());
                            sõidukid.Add(new Mootorratas(nimi, vanus));
                            break;
                        default:
                            Console.WriteLine("Vale valik, proovi uuesti.");
                            break;
                    }
                }
                Console.WriteLine("--- Sõidukite tulemused ---");
                foreach (var sõiduk in sõidukid)
                {
                    Console.WriteLine($"Sõiduki vahemaa: {sõiduk.ArvutaVahemaa()} km, Kulu: {sõiduk.ArvutaKulu()} liitrit");
                }
                double kogukulu = sõidukid.Sum(s => s.ArvutaKulu());
                Console.WriteLine($"Kogu kulu kõikide sõidukite peale kokku: {kogukulu} liitrit");
            }
            catch (FormatException)
            {
                Console.WriteLine("Sisestusviga! Palun sisesta numbriline väärtus.");
            }
        }
    }
}
