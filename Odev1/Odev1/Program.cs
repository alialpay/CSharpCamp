using System;
using static Odev1.Program;

namespace Odev1
{
    class Urun
    {
        public string UrunAdi { get; set; }
        public int Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int Barkod { get; set; }

    }
    class Program 
    {

        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Pijama";
            urun1.Fiyati = 70;
            urun1.Barkod = 147;
            urun1.Aciklama = "Pijama takımı";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Eşofman";
            urun2.Fiyati = 50;
            urun2.Barkod = 963;
            urun2.Aciklama = "Eşofman takımı";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Terlik";
            urun3.Fiyati = 30;
            urun3.Barkod = 258;
            urun3.Aciklama = "Ev içi terlik";


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " Fiyatı: " + urun.Fiyati);
            }





            /*  string urunAdi = "T-shirt";
              int urunFiyati = 50;
              int barkod = 123;
              string aciklama = "beyaz";

              Console.WriteLine(urunAdi);
              Console.WriteLine(urunFiyati);
              Console.WriteLine(barkod);
              Console.WriteLine(aciklama);

              string urunAdi1 = "Pantolon";
              int urunFiyati1 = 100;
              int barkod1 = 456;
              string aciklama1 = "siyah";

              Console.WriteLine(urunAdi1);
              Console.WriteLine(urunFiyati1);
              Console.WriteLine(barkod1);
              Console.WriteLine(aciklama1);
            *///bu tamamen yanlış bir yöntem.

            /* string urun1 = "T-shirt";
             string urun2 = "Pantolon";
             string urun3 = "Ayakkabi";

             Console.WriteLine(urun1);
             Console.WriteLine(urun2);
             Console.WriteLine(urun3);
            *///çok yanlış gitti...

            /*
            string[] urunler = new string[] {"T-shirt","Pantolon", "Ayakkabi"};
            foreach (string uruns in urunler)
            {
                Console.WriteLine(uruns);
            }
            
            Console.WriteLine("---------------------");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i]);
            }
            Console.WriteLine("---------------------");
            */






        }


    }
}
