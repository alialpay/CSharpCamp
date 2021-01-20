using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ali", "Engin" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            ////ekleme yapmak istedik diyelim
            //isimler = new string[5];
            //isimler[2];
            ////saçmalamış olduk.
            //// arrayler ekleme yapmak için çok da müsait bir yapı değil.
            ////Gerçek hayatta çok fazla array kullanılmaz bunun yerine List kullanılır

            List<string> isimler2 = new List<string> {"Ali","Engin","Tolga","Fözü" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Batu");
            Console.WriteLine(isimler2[4]);
            // rahatça ekleme işlemini yapabildik.
            // <> bu bir generic yapıdır.
        }
    }
}
