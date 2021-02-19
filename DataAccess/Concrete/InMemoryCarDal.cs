using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BeandId=1,ColorId=1, DailyPrice=70000, ModelYear=2015, Description="Mercedes"},
                new Car{Id=2, BeandId=2,ColorId=1, DailyPrice=60000, ModelYear=2015, Description="BMX"},
                new Car{Id=3, BeandId=3,ColorId=3, DailyPrice=50000, ModelYear=2018, Description="Honda"},
                new Car{Id=4, BeandId=4,ColorId=5, DailyPrice=50000, ModelYear=2014, Description="Toyota"},
                new Car{Id=5, BeandId=5,ColorId=4, DailyPrice=80000, ModelYear=2015, Description="Audi"},
            };


    }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToUpdate);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BeandId = car.BeandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
