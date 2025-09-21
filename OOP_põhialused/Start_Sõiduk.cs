using OOP_põhialused.Sõiduk_ülesanne;
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

                Console.WriteLine("Kas soovid laadida andmed failist (jah/ei)?");
                string laadiFailist = Console.ReadLine()?.Trim().ToLower();

                string failinimi = @"..\..\..\andmed.txt";

                if (laadiFailist == "jah" && File.Exists(failinimi))
                {
                    Funk.LaadiFailist(sõidukid, failinimi);
                }

                while (true)
                {
                    Console.WriteLine("Vali sõiduk: 1=Auto, 2=Jalgratas, 3=Buss, 4=Elektritõukeratas, 0=Välju");
                    string valik = Console.ReadLine();

                    if (valik == "0") break;

                    switch (valik)
                    {
                        case "1":
                            Console.Write("Kütusekulu (l/100km): ");
                            double aKulu = double.Parse(Console.ReadLine());
                            Console.Write("Vahemaa (km): ");
                            double aKm = double.Parse(Console.ReadLine());
                            sõidukid.Add(new Auto(aKulu, aKm));
                            break;
                        case "2":
                            Console.Write("Vahemaa (km): ");
                            double jKm = double.Parse(Console.ReadLine());
                            sõidukid.Add(new Jalgratas(jKm));
                            break;
                        case "3":
                            Console.Write("Kütusekulu (l/100km): ");
                            double bKulu = double.Parse(Console.ReadLine());
                            Console.Write("Vahemaa (km): ");
                            double bKm = double.Parse(Console.ReadLine());
                            Console.Write("Reisijate arv: ");
                            int r = int.Parse(Console.ReadLine());
                            sõidukid.Add(new Buss(bKulu, bKm, r));
                            break;
                        case "4":
                            Console.Write("Energiakulu (kWh/100km): ");
                            double eKulu = double.Parse(Console.ReadLine());
                            Console.Write("Vahemaa (km): ");
                            double eKm = double.Parse(Console.ReadLine());
                            sõidukid.Add(new Elektritõukeratas(eKulu, eKm));
                            break;
                        default:
                            Console.WriteLine("Vale valik!");
                            break;
                    }
                }

                // --- вывод всех результатов ---
                Console.WriteLine("--- Sõidukite tulemused ---");
                foreach (var s in sõidukid)
                {
                    Console.WriteLine($"{s} | Kulu: {s.ArvutaKulu():F2} | Vahemaa: {s.ArvutaVahemaa():F2}");
                }

                double koguKulu = sõidukid.Sum(s => s.ArvutaKulu());
                Console.WriteLine($"Kogu kulu: {koguKulu:F2}");

                // --- сохранение в файл ---
                Funk.SalvestaFaili(sõidukid, failinimi);
                Console.WriteLine($"Andmed salvestatud faili: andmed.txt");
            }
            catch (FormatException)
            {
                Console.WriteLine("Viga: palun sisesta numbrid õigesti!");
            }
        }
    }
}
