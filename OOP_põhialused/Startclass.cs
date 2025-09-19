using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_põhialused
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            //Inimene inimene1 = new Inimene();
            //inimene1.Nimi = "Juku";
            //inimene1.Vanus = 12;
            //inimene1.Tervita(); //действие

            //Inimene inimene2 = new Inimene("Kati", 28);

            //Õpilane õpilane1 = new Õpilane();
            //õpilane1.Nimi = "Juku";
            //õpilane1.Vanus = 12;
            //õpilane1.Rühm_Klass = "3D";
            //õpilane1.Kool = "21";

            //Töötaja töötaja1 = new Töötaja();
            //töötaja1.Nimi = "Juku";
            //töötaja1.Vanus = 12;
            //töötaja1.Ametikoht = "Autojuht";
            //töötaja1.Tervita();
            //töötaja1.Töötan();
            //töötaja1.Mida_tee();

            //töötaja1.Tunnid = 160;
            //double palk = töötaja1.ArvutaPalk();
            //Console.WriteLine($"Algne konto on {töötaja1.KontoPank.Saldo} eurot.");
            //töötaja1.KontoPank.Saldo += palk;
            //Console.WriteLine($"Pärast palka on kontol {töötaja1.KontoPank.Saldo} eurot.");
            //töötaja1.KontoPank.VõtaRaha(200); 
            //Console.WriteLine($"Pärast sularaha võtmist on kontol {töötaja1.KontoPank.Saldo} eurot.");
            //töötaja1.KontoPank.LisaRaha(500);
            //Console.WriteLine($"Pärast raha lisamist on kontol {töötaja1.KontoPank.Saldo} eurot.");

            List<IKujund> kujundid = new List<IKujund>();

            while (true)
            {
                Console.WriteLine("\nVali kujund: 1=Ruut, 2=Ring, 3=Kolmnurk, 0=Välju");
                string valik = Console.ReadLine();

                if (valik == "0") break;

                switch (valik)
                {
                    case "1":
                        Console.Write("Sisesta küljepikkus: ");
                        double külg = double.Parse(Console.ReadLine());
                        kujundid.Add(new Ruut(külg));
                        Console.WriteLine("\n--- Kujundite tulemused ---");
                        foreach (var kujund in kujundid)
                        {
                            Console.WriteLine($"Pindala: {kujund.ArvutaPindala():F2}, Ümbermõõt: {kujund.ArvutaÜmbermõõt():F2}");
                        }
                        break;

                    case "2":
                        Console.Write("Sisesta raadius: ");
                        double r = double.Parse(Console.ReadLine());
                        kujundid.Add(new Ring(r));
                        Console.WriteLine("\n--- Kujundite tulemused ---");
                        foreach (var kujund in kujundid)
                        {
                            Console.WriteLine($"Pindala: {kujund.ArvutaPindala():F2}, Ümbermõõt: {kujund.ArvutaÜmbermõõt():F2}");
                        }
                        break;

                    case "3":
                        Console.Write("Sisesta kolm külge (A B C): ");
                        string[] osad = Console.ReadLine().Split();
                        double a = double.Parse(osad[0]);
                        double b = double.Parse(osad[1]);
                        double c = double.Parse(osad[2]);
                        kujundid.Add(new Kolmnurk(a, b, c));
                        Console.WriteLine("\n--- Kujundite tulemused ---");
                        foreach (var kujund in kujundid)
                        {
                            Console.WriteLine($"Pindala: {kujund.ArvutaPindala():F2}, Ümbermõõt: {kujund.ArvutaÜmbermõõt():F2}");
                        }
                        break;

                    default:
                        Console.WriteLine("Tundmatu valik.");
                        break;
                }
            }

            Console.WriteLine("\n--- Kujundite tulemused ---");
            foreach (var kujund in kujundid)
            {
                Console.WriteLine($"Pindala: {kujund.ArvutaPindala():F2}, Ümbermõõt: {kujund.ArvutaÜmbermõõt():F2}");
            }

            //4, 5-Создайте свой основной класс и 2 подкласса и используйте их здесь.
            ////доделать
            //Koer koer1 = new Koer();
            //koer1.Nimi = "Kohev";
            //koer1.Vanus = 6;
            //koer1.Liik = "Koer";
            //koer1.Tervita();
            //koer1.TeeHääl();
            //koer1.Tee();
            //koer1.Sööma();

            //Linnud linnud1 = new Linnud();
            //linnud1.Nimi = "icek";
            //linnud1.Vanus = 12;
            //linnud1.Liik = "Vares";
            //linnud1.Tervita();
            //linnud1.TeeHääl();
            //linnud1.Tee();
            //linnud1.Sööma();

            //Kala kala1 = new Kala();
            //kala1.Nimi = "icek";
            //kala1.Vanus = 2;
            //kala1.Liik = "Haug";
            //kala1.Tervita();
            //kala1.TeeHääl();
            //kala1.Tee();
            //kala1.Sööma();


        }
    }
}
