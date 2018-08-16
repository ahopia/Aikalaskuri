using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AikaEroLaskuri
{
    class Program
    {
        static void Main(string[] args)
        {


            string dateString2 = "2018-04-30 10:40";
            string dateString3 = "2018-05-02 13:05";

            DateTime vaihdettu1 = MuutaPvm(dateString2);
            DateTime vaihdettu2 = MuutaPvm(dateString3);

            TimeSpan tulos = PvmEro(vaihdettu2, vaihdettu1);

            Console.WriteLine(tulos);

            Console.WriteLine("Päiviä: \t" + tulos.Days);
            Console.WriteLine("Tunteja: \t" + tulos.Hours);
            Console.WriteLine("Minuutteja: \t" + tulos.Minutes);

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
