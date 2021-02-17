using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{   //S'O'LID
    //Open Closed Principle    projene ilave yaptığında mevcut kodların hiç birisine dokunmamalısın demek
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /*    foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.Description);
                }
            */
            
             /*   foreach (var car in carManager.GetAllByBrandId(2))
                {
                    Console.WriteLine("Model Year:" + car.ModelYear + ", Daily Price:" + car.DailyPrice + ", Description:" + car.Description);
                }
             */
            foreach (var car in carManager.GetByDailyPrice(300000,500000))
            {
                Console.WriteLine("Model Year:" + car.ModelYear + ", Daily Price:" + car.DailyPrice + ", Description:" + car.Description);
            }


        }
    }
}
