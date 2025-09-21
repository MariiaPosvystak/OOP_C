using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused.Sõiduk_ülesanne
{
    internal class Funk
    {
        public static void LaadiFailist(List<ISõiduk> sõidukid, string failinimi)
        {
            foreach (var rida in File.ReadAllLines(failinimi))
            {
                var osad = rida.Split(';');
                if (osad.Length < 2) continue;

                string tüüp = osad[0].ToLower();
                ISõiduk s = null;

                switch (tüüp)
                {
                    case "auto":
                        if (osad.Length >= 3 &&
                            double.TryParse(osad[1], out double aKulu) &&
                            double.TryParse(osad[2], out double aKm))
                            s = new Auto(aKulu, aKm);
                        break;
                    case "jalgratas":
                        if (double.TryParse(osad[1], out double jKm))
                            s = new Jalgratas(jKm);
                        break;
                    case "buss":
                        if (osad.Length >= 4 &&
                            double.TryParse(osad[1], out double bKulu) &&
                            double.TryParse(osad[2], out double bKm) &&
                            int.TryParse(osad[3], out int r))
                            s = new Buss(bKulu, bKm, r);
                        break;
                    case "elektritõukeratas":
                        if (osad.Length >= 3 &&
                            double.TryParse(osad[1], out double eKulu) &&
                            double.TryParse(osad[2], out double eKm))
                            s = new Elektritõukeratas(eKulu, eKm);
                        break;
                }

                if (s != null) sõidukid.Add(s);
            }

            Console.WriteLine("Andmed failist laaditud!");
        }

        public static void SalvestaFaili(List<ISõiduk> sõidukid, string failinimi)
        {
            using (StreamWriter sw = new StreamWriter(failinimi))
            {
                foreach (var s in sõidukid)
                {
                    if (s is Auto auto)
                        sw.WriteLine($"auto;{auto.ArvutaKulu() * 100 / auto.ArvutaVahemaa()};{auto.ArvutaVahemaa()}");
                    else if (s is Jalgratas jalgratas)
                        sw.WriteLine($"jalgratas;{jalgratas.ArvutaVahemaa()}");
                    else if (s is Buss buss)
                        sw.WriteLine($"buss;{buss.ArvutaKulu() * buss.ArvutaVahemaa() / 100};{buss.ArvutaVahemaa()};1");
                    else if (s is Elektritõukeratas tõuks)
                        sw.WriteLine($"elektritõukeratas;{tõuks.ArvutaKulu() * 100 / tõuks.ArvutaVahemaa()};{tõuks.ArvutaVahemaa()}");
                }
            }
        }
    }
}
