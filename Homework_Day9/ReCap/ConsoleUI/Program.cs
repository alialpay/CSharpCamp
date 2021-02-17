using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{   //S'O'LID
    //Open Closed Principle     projene ilave yaptığında mevcut kodların hiç birisine dokunmamalısın demek
    class Program
    {
        static void Main(string[] args)
        {
            //DescriptionTest();

            //Console.WriteLine("");
            //Console.WriteLine("--------------------------------");

            //GetAllBrandIdTest();

            //Console.WriteLine("");
            //Console.WriteLine("--------------------------------");

            //DailyPriceTest();

            //Console.WriteLine("");
            //Console.WriteLine("--------------------------------");

            //BrandTest();

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + car.ModelYear + "     renk:" + car.ColorName);
            }


        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void DescriptionTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetAllBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByBrandId(2))
            {
                Console.WriteLine("Model Year:" + car.ModelYear + ", Daily Price:" + car.DailyPrice + ", Description:" + car.Description);
            }
        }

        private static void DailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetByDailyPrice(250, 400))
            {
                Console.WriteLine("Model Year:" + car.ModelYear + ", Daily Price:" + car.DailyPrice + ", Description:" + car.Description);
            }
        }
    }
}
