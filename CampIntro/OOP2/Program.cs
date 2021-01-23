using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Ali";
            //musteri1.Soyadi = "Alpay";
            //musteri1.Id = 1;
            //musteri1.TcNo = "2222222";
            //musteri1.MusteriNo = "123456";
            //musteri1.SirketAdi = "?"; // bahsedilen değer SirketAdi

            //// (individual - coorporate) Gerçek - Tüzel müşteriler var. 
            ////şahıs ve şirket. ikisi aynı yerden inherite edilemez. Bu yüzden yalnızca musteri classını kullanmak yerine gercekmusteri ve tuzelmusteri classlarını tanımladık.
            //// bunlar farklı müşteri tiplleri, birbirleri yerine kullanılamaz.
            //// SOLID'in L harfi
            ///

            // Ali Alpay
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Alpay";
            musteri1.TcNo = "741852963";

            // kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "78963";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "98756";

            //*************

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);



        }
    }
}
