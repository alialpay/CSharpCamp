using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Ali");

            Console.WriteLine(isimler.Lentgth);
            isimler.Add("Deniz");
            Console.WriteLine(isimler.Lentgth);

            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
