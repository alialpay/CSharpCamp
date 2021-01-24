using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urun.Adi);
            //
            //
            //
        }

        //ekle2ye ekleme yapınca üç sayfayı düzeltmek zorunda kaldık. bu yanlış stil
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler, Sepete eklendi : " + urunAdi);
        }

    }
}
