using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "samed";
            int yas = 33;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Samed Erdemir";
            kurs1.izlenmeOrani = "68";

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java#";
            kurs2.Egitmen = "İbrahim Erdemir";
            kurs2.izlenmeOrani = "85";

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyton";
            kurs3.Egitmen = "Harun Erdemir";
            kurs3.izlenmeOrani = "50";


            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Furkan Erdemir";
            kurs4.izlenmeOrani = "92";


            Kurs kurs5 = new Kurs();
            kurs5.KursAdi = "visual basic";
            kurs5.Egitmen = "Emre Erdemir";
            kurs5.izlenmeOrani = "62";

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4, kurs5 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "  : " + kurs.Egitmen);
            }




            Console.WriteLine("Hello World");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public string izlenmeOrani { get; set; }
    }
}