
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract.BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = 1996, FirstName = "MUHAMMED ALİ", LastName = "ALPAY" , Id = 123, NationalityId= 13324058152});
            Console.ReadLine();
        }
    }
}
