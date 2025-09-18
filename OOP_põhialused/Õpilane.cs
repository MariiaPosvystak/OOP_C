using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    internal class Õpilane: Inimene
    {
        public string Rühm_Klass;
        public string Kool;
        public override void Mida_tee()
        {
            Console.WriteLine($"{Nimi} õpib koolis");
        }
    }
}
