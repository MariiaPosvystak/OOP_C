using OOP_põhialused;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ülesande:
//Loo liides ISõiduk, milles on kaks meetodit:
//double ArvutaKulu()
//double ArvutaVahemaa(
//Loo vähemalt 3 erinevat klassi, mis rakendavad liidest:
//Auto – arvutab kütusekulu ja teepikkuse
//Jalgratas – ei kuluta kütust, ainult vahemaa
//Buss – kulu ja vahemaa, kulu jagatakse reisijate vahel
//Igal klassil peab olema:
//Konstruktor, mis võtab vajalikud parameetrid (nt kütusekulu, km, reisijate arv)
//Rakendatud liidese meetodid (ArvutaKulu, ArvutaVahemaa)
//Loo Main() meetod eraldi failis, kus:
//Kasutajalt küsitakse sisendi kaudu erinevaid sõidukeid
//Need lisatakse List<ISõiduk> listi
//Lõpus kuvatakse iga sõiduki kulu ja vahemaa
//Lisapunktide saamiseks:
//✅ Lisa veel üks uus sõidukiklass (nt Elektritõukeratas, Mootorratas jne)
//✅ Kuvamisel kasuta ToString() meetodit ( 
//public override string ToString()
//{
//    return $"{Nimi}, Vanus: {Vanus}, Palk: {ArvutaPalk()}";
//}
//)
//✅ Lisa sisendile veakontroll
//✅ Arvuta kogu kulu kõikide sõidukite peale kokku
//✅ Kasuta .txt faili andmete sisestamiseks
// Failinõuded:
//Lisa kommentaarid koodi selgitamiseks
//Testi, et programm töötab ja annab mõistlikke tulemusi
namespace OOP_põhialused
{
    public interface ISõiduk
    {
        double ArvutaKulu();
        double ArvutaVahemaa();
    } 
}