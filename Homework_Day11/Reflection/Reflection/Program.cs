using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        // BTK Akademi -- Engin Demiroğ -- C# Bölüm 26
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            
            //dortIslem.Topla2();
            //Console.WriteLine(dortIslem.Topla(3, 3));
            //Console.WriteLine(dortIslem.Topla2());

            var type = typeof(DortIslem);

            //DortIslem dortIslem1 = (DortIslem)Activator.CreateInstance(type,6,9);
            //Console.WriteLine(dortIslem1.Topla(4, 5));
            //Console.WriteLine(dortIslem1.Topla2());

            var instance = (DortIslem)Activator.CreateInstance(type, 6, 9);
            // Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));
            
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance,null));



        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
}
