using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
       // <T> .Bu, ben MyList imde T ile çalışacağım demek. T yerine string yazsaydık sadece stringe bağlı kalırdık. 

       T[] items;        //arrayi normalde string[] items şeklinde tanımlardık. Ama biz sadece stringe bağlı kalmak istemiyoruz.
        public MyList()       //Constructor, class ile aynı isimdedir.
        {
            items = new T[0];       //Constructor, içinde bulunduğu class'ı new'lendiğinde direkt çalışan metottur.    
        }
       public void Add(T item)
        {
            T[] tempArray = items;            //tempArray geciciArray. items'ın referans numarasını tempArraye verdik
            items = new T[items.Length+1];      //18.satırdan ÖNCE BURAYA BAK//ekleme yapacağın sıra mevcut arrayine +1 boşluk açılıyor.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
