using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface implemente edilmek zorundadır.
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
