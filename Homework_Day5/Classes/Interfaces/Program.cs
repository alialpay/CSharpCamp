using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] { new SqlServerCustomerDal(), new OracleCustomerDal(),new MySqlCustomerDal()};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();

        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager(); // interface newlenmez.
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            //manager.Add(new Customer { Id = 1, FirstName = "Ali", LastName = "Alpay", Adress = "İncek" }); //farklı bir yazım tekniği

            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Alpay",
                Adress = "İncek"
            };


            Student student = new Student() { Id = 2, FirstName = "Barış", LastName = "Alpay", Departmant = "Hukuk" };

            manager.Add(customer);
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }         // interface içerisinde özellik tanımlarken public olmaz. zaten genellikle metot tanımlanır...
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Customer : IPerson            // özellik tanımladıysan implemente etmek gerekir. 
    {
        public int Id { get; set; }     // public olan versiyonlarının yazılması yeterlidir. Ampulden implemente edince throwlu yolluyor.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
