using System;

namespace Inheritance
{
    class Program
    {              // interfaceler inheritance mantığıyla kullanılabildiği için ikisi arasında seçim yapmakta zorlanılırsa interface tercih edilmeli.

        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            //customer.

            Person[] persons = new Person[] { new Customer {FirstName="Ali" }, new Student {FirstName="Engin" }, new Person {FirstName="Batu" } };
            // interfaceden farkı person() tanımlanabiliyor
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person2
    {

    }
    class Person        // interface ile aynı gibi. Fark: interface tek başına bir anlam ifade etmiyordu ama class Person anlamlı.
                        // ama abstract sınıflarda kesin inheritance kullanılır.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person           //, Person2 interfacedeki gibi farklı kaynaklardan aktarım yapamıyoruz.
                                      // bir classın yalnızca bir babası var. kalıtım. eğer Person2 bir interface olursa virgülle ayırarak yazılabilir. 
                                      // ancak burada dikkat edilmesi gereken önce inherite edilen class sonra interface class yazılmalı
    {                                 // yani bir nesne yalnızca bir kere inherite(inheritance) edilir. ama birden fazla implemente(interface) edilebilir4
                                      // class ların tek başına bir anlamı vardır. ama interfacelerin tek başına bir anlamı yoktur!!!!!!!!!!!!!!!!!!!!!  
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
