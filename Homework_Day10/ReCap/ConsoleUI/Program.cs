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

            //DataTest();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());


            //var result = carManager.GetAll();
            var result = rentalManager.GetRentalDetails(1).Data;

            foreach (var rental in result)
            {
                Console.WriteLine(rental.CustomerName + " " + rental.ReturnDate);
            }
        }
        private static void DataTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.BrandName + car.ModelYear + "     renk:" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllBrandIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByBrandId(2).Data)
            {
                Console.WriteLine("Model Year:" + car.ModelYear + ", Daily Price:" + car.DailyPrice + ", Description:" + car.Description);
            }
        }

        private static void DailyPriceTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetByDailyPrice(250, 400);
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Model Year:" + car.ModelYear + ", Daily Price:" + car.DailyPrice + ", Description:" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
