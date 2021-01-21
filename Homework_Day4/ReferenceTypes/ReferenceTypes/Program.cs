using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            // int, decimal, float, enum, boolean == value types
            int no1 = 10;
            int no2 = 20;

            no1 = no2;
            no2 = 100;

            Console.WriteLine("No1 :" + no1 ); // No1 : 20

            // arrays, clas, interface... == reference types

            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };

            numbers1 = numbers2;
            numbers2[0] = 1000;

            Console.WriteLine("numbers1[0] = " + numbers1[0]);
            */
            //---------------------------------------------------

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Ali";

            person2 = person1;
            person1.FirstName = "Derin";

            // Console.WriteLine(person2.FirstName);
            
            //---------------------------------------------------

            Customer customer = new Customer();
            customer.FirstName = "Tolga";
            customer.CreditCardNumber = "132184846565";

            Employee employee = new Employee();
            employee.FirstName = "Candan";

            Person person3 = customer;
            customer.FirstName = "Batu";


            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            //personManager.Add(person3);
            //personManager.Add(customer);
            personManager.Add(employee);

        }
    }

    // base class : Person
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmptloyeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)   // Person, Customer, Employee
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
