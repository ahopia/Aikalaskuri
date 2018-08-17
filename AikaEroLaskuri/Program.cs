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

            Console.WriteLine("Anna alku pvm muodossa vvvv-kk-pp hh:mm");   
            DateTime alkuAika = LueLuku();

            Console.WriteLine("\r\nAnna loppu pvm muodossa vvvv-kk-pp hh:mm");
            DateTime loppuAika = LueLuku();

            TimeSpan tulos = PvmEro(loppuAika, alkuAika);

            Console.WriteLine("\r\nPäivämäärien ero on " + tulos + "\r\n");

            Console.WriteLine("Päiviä: \t" + tulos.Days);
            Console.WriteLine("Tunteja: \t" + tulos.Hours);
            Console.WriteLine("Minuutteja: \t" + tulos.Minutes + "\r\n");

            Console.WriteLine(tulos.Days + " päivää " + tulos.Hours + " tuntia " + tulos.Minutes + " minuuttia");
            Console.ReadLine();
        }

        private static DateTime LueLuku() // tätä voisi käyttää luvu lukemiseen ja formaatin tarkistamiseen
        {
            Boolean luuppi = true;
            Console.Write("> ");
            DateTime tulos = DateTime.MinValue;

            while (luuppi)
            {
                string annettuPvm = Console.ReadLine();
                Boolean onnistui = ParsePvm(annettuPvm, out tulos);
                if (onnistui)
                {
                    luuppi = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\r\nLuku väärässä formaatissa, anna pvm uudelleen muodossa \r\n  vvvv-kk-pp hh:mm");
                    Console.Write("> ");
                }

            }

            return tulos;

        }


        public static Boolean ParsePvm(string pvm, out DateTime muuttuja)
        {
            return DateTime.TryParse(pvm, out muuttuja);
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
