using System;

namespace Attributes
{
    class Program
    {
        // Attribute'lar ilgili nesne için bir kural oluşturur.
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Ali", LastName = "Alpay", Age = 24 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }
        [ToTable("Customers")] // Bu Customer nesnesi veri tabanında Customers tablosuna denk gelir diyebiliriz
        [ToTable("TblCustomers")] // En son Bak // Bu özelliği tablo isminden emin olmadığımızda kullanırız. ya buna ya da buna ekle anlamına gelir. 
        // [RequiredProperty] // .class kullanıldığında buraya yazılabilir
        class Customer
        {
            public int Id { get; set; }
            [RequiredProperty] // Mesela FirstName i girmek zorunlu olsun isteyebiliriz
            public string FirstName { get; set; }
            [RequiredProperty] // AttributeUsage'da .class kullanılırsa burası kızar
            public string LastName { get; set; }
            [RequiredProperty]
            public int Age { get; set; }
        }
        class CustomerDal
        {
            [Obsolete("Don't use Add, instead use AddNew Method")] // bu hazır bir attribute'dür. Bu methodun daha güncel bir hali var onu kullanabilirsin şeklinde uyarır. Obsolete eski demek
            public void Add(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);

            }
            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0},{1},{2},{3} added", customer.Id, customer.FirstName, customer.LastName, customer.Age);

            }
        }
        [AttributeUsage(AttributeTargets.Property)] // "| AttributeTargets.Field" eklersek: Property'lere ve Field'lara uygulayabilirsin demek olur
        class RequiredPropertyAttribute : Attribute
        {

        }
        [AttributeUsage(AttributeTargets.Class,AllowMultiple =true)] // AllowMultiple'ı true yaparsak birden fazla kullanılabilir demek olur. Yukarı tekrar bak
        class ToTable : Attribute
        {
            string _tableName;

            public ToTable(string tableName)
            {
                _tableName = tableName;
            }
        }
    }
}
