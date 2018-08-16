using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @author Arto Hopia
/// version 17.8.2018
/// Laskee aikaeron kahden päivämäärän välillä tulostaen sen muodossa pvm:dd:min
/// </summary>

namespace AikaEroLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anna alku pvm muodossa vvvv-kk-pp hh:mm");   // tee try-parse oikeaan formaattiin
            Console.Write("> ");
            string alkuAika1 = Console.ReadLine();

            Console.WriteLine("\r\nAnna loppu pvm muodossa vvvv-kk-pp hh:mm");
            Console.Write("> ");
            string loppuAika2 = Console.ReadLine();

            //string dateString2 = "2018-04-30 10:40";
            //string dateString3 = "2018-05-02 13:05";

            string dateString2 = loppuAika2;
            string dateString3 = alkuAika1;

            DateTime vaihdettu1 = MuutaPvm(dateString2);
            DateTime vaihdettu2 = MuutaPvm(dateString3);

            TimeSpan tulos = PvmEro(vaihdettu2, vaihdettu1);

            Console.WriteLine(tulos + "\r\n");

            Console.WriteLine("Päiviä: \t" + tulos.Days);
            Console.WriteLine("Tunteja: \t" + tulos.Hours");
            Console.WriteLine("Minuutteja: \t" + tulos.Minutes + "\r\n");


            Console.WriteLine(tulos.Days + " päivää " + tulos.Hours + " tuntia " + tulos.Minutes + " minuuttia");
            Console.ReadLine();
        }

        public static DateTime MuutaPvm(string pvm)
        {
            DateTime muutettu = DateTime.Parse(pvm, System.Globalization.CultureInfo.InvariantCulture);

            return muutettu;

        }


        public static TimeSpan PvmEro(DateTime alku, DateTime loppu)

        {
            return (alku - loppu);

        }


    }
}
