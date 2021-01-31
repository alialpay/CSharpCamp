using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;        // Bir iş sınıfı, başka bir sınıfı new lemez. Bu şekilde injection yapıyoruz.
                                // Ampulden generate constructor şıkkını kullanıyoruz. İş sınıflarında constructor kullanıyoruz.
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            //iş kodları
            return _carDal.GetAll();
        }
    }
}
