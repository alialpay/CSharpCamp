using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> sehirler = new List<string>();
            //sehirler.Add("Ankara");

            MyList<string> sehirler2 = new MyList<string>();

            sehirler2.Add("Ankara");
            Console.WriteLine(sehirler2.Length);

            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Length);

            foreach (var item in sehirler2.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
    class MyList<T> //Generic class
    {
        T[] items;
        public MyList()         // constructor sahip olduğu class newlendiğinde otomatik çalışır
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }
        public T[] Items
        {
            get { return items; }
        }
    }
}
