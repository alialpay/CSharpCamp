using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
             * Constructor bir class ı new'lediğimiz zaman çalışan bloktur.
             * Class ilk kez oluştuğunda bir kere çalışır ve bir daha çalışmaz.
             * Class ilk kez yapılandırıldığında çalışan blok.Türkçesi zaten yapıcı. 
             */

            Customer customer1 = new Customer { Id = 1, FirstName = "Ali", LastNanme = "Alpay", City = "Ankara" };  // bu gösterimde bu public Customer() kullanılır.

            Customer customer2 = new Customer(2,"Barış", "Alpay","Ankara"); // bu public Customer(int id, string firstName, string lastName, string city) bu şekilde.


        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName, string city) // metot parametreleri camelCase dir.
        {
            Id = id;
            FirstName = firstName;
            LastNanme = lastName; 
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastNanme { get; set; }
        public string City { get; set; }

    }


}
