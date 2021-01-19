using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Isim = "Engin";
            musteri1.Soyisim = "Demiroğ";
            musteri1.MusteriNo = 8201;

            Musteri musteri2 = new Musteri();
            musteri2.Isim = "Ali";
            musteri2.Soyisim = "Alpay";
            musteri2.MusteriNo = 2525;

            Musteri[] musteriler = { musteri1, musteri2 };

            foreach (var musteri in musteriler) // Müşterileri listeliyoruz. Kaç adet müşteri varsa ekrana yazılacak
            {
                Console.WriteLine(musteri.Isim);
                Console.WriteLine(musteri.Soyisim);
                Console.WriteLine(musteri.MusteriNo);
                Console.WriteLine("-----------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("Eklenen Müşteri");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("\nMüşteri Listesi");
            foreach (Musteri customer in musteriler)
            {
                musteriManager.List(customer);
            }

            Console.WriteLine("\n");
            musteriManager.MusteriSil(musteri2);

        }
    }
}
