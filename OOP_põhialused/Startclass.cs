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
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Juku";
            inimene1.Vanus = 12;
            inimene1.Tervita(); //действие

            Inimene inimene2 = new Inimene("Kati", 28);

            Töötaja töötaja1 = new Töötaja();
            töötaja1.Nimi = "Juku";
            töötaja1.Vanus = 12;
            töötaja1.Ametikoht = "Autojuht";
            töötaja1.Tervita();
            töötaja1.Töötan();

            //4, 5-Создайте свой основной класс и 2 подкласса и используйте их здесь.
            //доделать
            //Loomad loomad2 = new Loomad();
            //loomad2.Nimi = "Kohev";
            //loomad2.Vanus = 4;
            //loomad2.Liik = "Kass";
            //loomad2.Tervita();
            //loomad2.Liikid();


        }
    }
}
