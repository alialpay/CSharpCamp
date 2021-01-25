using System;

namespace Interfaces
{// Main kısmı 3. bölüm (son). Açıklamalardaki sıralamaya göre blokları okumak faydalı olacaktır.
    class Program
    {
        // interface new'lenemez..
        static void Main(string[] args)
        {
            //IPersonManager personManager = new IPersonManager();  new'leyemedik
            //IPersonManager customerManager = new CustomerManager();       // ama böyle yapabiliyoruz tabiki
            //customerManager.Add();                                   // interfaceler onu implemente eden classın referansını tutabilir.
            // Customer veya Employee classlarını newleyebiliriz
            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add2(new CustomerManager());             // add parantezine ilk başta yukarıdaki customerManageri koymuştuk 
                                                                    // add içinde artık ister Customer ister Employee new'leyebiliriz
                                                                    // iki ayrı işlemden kurtulduk. artık değişiklikler daha kolay
            projectManager.Add2(new InternManager());
        }
    }
                    // mesela yeni bir stajyer classı ekleyelim
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Strajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Strajyer güncellendi");
        }
    }

    class ProjectManager
    {           // genel bir add operasyonu
        public void Add2(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

    // 2.Bölüm
    interface IPersonManager
    {
        // unimplemented operation--burada operasyonun doldurulmuyor. 
        // böylece farklı yerlerde farklı çıktılar alınabiliyor. yani müşteri için ayrı, personel için ayrı ekleme
        void Add();
        void Update();      // bu imzayı daha sonra ekledik ve aşağıda IPersonManageri implemente eden classlar 
                            //uyarı verdi. yani interface içerisinde bulunan bütün operasyonlar onu implemete
                            //eden classlar tarafından tanımlanmak ZORUNDA
    }
    class CustomerManager : IPersonManager  // Customer manager artık void Add() imzasına sahip
    {                                       // implemente edilen imzalar kullanılmak zorundadır.
        public void Add()                   // operasyonun içerisi artık burada müşteri için doldurulacak
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager  // javada yazarken : yerine implements yazıyorduk
    {
        public void Add()                   // burada ise personer için doldurulacak
        {                   // interface sayesinde hem müşteriye hem de personele farklı kodlar yazabiliyoruz.
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }       // class - inherits ---------- interface implements



    /*  1.Bölüm
    //---------------------------------------------------------------------------------------------------------
    // inheritance örneği - kalıtım örneği
    
    class Person
    {   // implemented operation--tamamlanmış, içi doldurulmuş operasyon
        public void Add()               // burada Add() üyesinin içi dolu olmak zorunda
        {                               // interface olsaydı sadece imzası yeterliydi.
            Console.WriteLine("Added");
        }
    }
    class Customer:Person   // javada : yerine extends yazıyorduk. classtan kalıtım alıyorduk
    {                          //Customer class'ı Person'dan miras alıyor. Customer Person'ı inherite ediyor.
                               //Customer, Person'ın üyelerini de kullanabilir demek oluyor.
        //Customer kendi içindeki operasyonlara ek olarak kalıtım aldığı sınıfın operasyonunu kullanabilir.
    }
    class Employee : Person  // javada yazarken : yerine implements yazıyorduk
    {
           // Add() operasyonu sabit ve hem müşteri hem personel için de aynı kurallara sahip
    } 
    //----------------------------------------------------------------------------------------------------------
    */


}
