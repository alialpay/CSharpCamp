using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Yeni Müşteri : " + musteri.Isim);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + "  " + musteri.Soyisim + "  "  + musteri.MusteriNo );
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri : " + musteri.Isim);
        }
    }
}
