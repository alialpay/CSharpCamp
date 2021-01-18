using System;

namespace Ref_Out
{
    class Program
    {
        // ------------------------------------------------------------ref anahtar kelimesi------------------------------------------------------------ 
        /*
        static void Main(string[] args)
        {
            string text1 = "değer";  // ii) ref keywordünde mutlaka text1 değişkeninin bir karşılığı olmalı. **********fark**********
            string text2 = "";
            var combine = fonk(ref text1, text2); // ii) ref keywordü eklendi

            Console.WriteLine(combine);
            Console.WriteLine(text1); // i) fonk içinde değişse bile text1 bir değer tiptir. bu yüzden "değer" değişmedi. referans tip olsa değişirdi.
                                      // ii) ref keywordü eklendikten sonra "değer değişti". text1 artık ref tip gibi davranıyor
        }
        static string fonk(ref string text1, string text2) // i) fonk tanımlarken void yapmadık. void git bu işi yap demek. ama ben fonk bir değer döndürsün istedim.
        {                                                   // i) eğer bir değer döndürmek istiyorsak void yerine döndürmek istediğimiz tipi yazarız.
            text1 = "değer değişti";                        // ii) ref keywordü sonradan eklendi.
            return text1 + text2;
        }
        */
        // ------------------------------------------------------------out anahtar kelimesi------------------------------------------------------------ 
        static void Main(string[] args)
        {
            string text1;       // out keywordü kullanıldığında text1 değişkeninin bir karşılığı olmak zorunda değil
            string text2 = "";
            var combine = fonk(out text1, text2); // out ile ref keywordü kullanım açısından aynıdır.

            Console.WriteLine(combine);
            Console.WriteLine(text1); // out kullanıldığı için referans tip gibi davrandı ve fonk metodunda olduğu gibi "değer değişti" oldu.
                                      
        }
        static string fonk(out string text1, string text2) // out kullanacağımız için metot içerisinde de out yazmamız gerekti
        {                                                   
            text1 = "değer değişti";   // out kullanıldığı için text1 mutlaka metot içerisinde set edilmeli. **********fark**********                
            return text1 + text2;
        }

    }
}
