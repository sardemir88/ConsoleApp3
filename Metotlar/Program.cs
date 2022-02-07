using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.fiyati = 15;
            urun1.aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.fiyati = 80;
            urun2.aciklama = "adana karpuzu";

            Urun[] urunler = new urun[] {urun1,urun2}

            foreach (var urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.fiyati);
                Console.WriteLine(urun.aciklama);
                Console.WriteLine(urun."--------------");


            }

            Console.WriteLine("-------Metotlar----------");

            Console.WriteLine("hellooooo");
        }

    }

}



