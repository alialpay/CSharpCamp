using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;    // Car classından _cars işlem listemizi tanımlıyoruz
        public InMemoryCarDal() //constructorda listemize objeler ekliyoruz
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=1996, DailyPrice=250000, Description="Siyah Pickup otomobil"},
                new Car{Id=1, BrandId=2, ColorId=3, ModelYear=2020, DailyPrice=140000, Description="Lacivert Hatchback otomobil"},
                new Car{Id=1, BrandId=3, ColorId=4, ModelYear=2009, DailyPrice=150000, Description="Kırmızı Sedan otomobil"},
                new Car{Id=1, BrandId=4, ColorId=2, ModelYear=2015, DailyPrice=17500, Description="Beyaz Suv otomobil"},
            };
        }
        public void Add(Car car)    // Add metoduna Car clasından obje atıyoruz.
        {
            _cars.Add(car); // List metodu olan Add ile ekleme işlemi yapıyoruz.
        }

        public void Delete(Car car) // Delete metoduna Car classından obje atıyoruz
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);   // Car classından carToDelete isminde yeni bir obje oluşturup Linq sorgusu ile kayıtlı objeler arasından saptama gerçekleştiriyoruz.
            _cars.Remove(carToDelete);  // Linq sorgusu ile saptadığımız objeyi List metodu olan Remove ile silme işlemini yapıyoruz.
        }

        public List<Car> GetAll()   // Car Listesinde Get All metodu tanımlıyoruz.
        {
            return _cars;   // işlem listemizi döndürüyoruz.
        }

        public void Update(Car car) // Car classından car isimli bir obje kullanan Update metodu tanımlıyoruz.
        {
            Car carToUpdate = null;     // Car classımızdan carToUpdate isminde Linq sorgusuyla güncellenecek ürünü saptayacak bir işlem objesi tanımlıyoruz.
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);   // Güncellenecek ürünün saptanması için Linq sorgusu.
            carToUpdate.Id = car.Id;            
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
        public List<Car> GetById(int id)    
        {
            return _cars.Where(c => c.Id == id).ToList();   
        }
    }
}
