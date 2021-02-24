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
        List<Car> _cars = new List<Car>
        {
            new Car {Id=1, BrandId=2, ColorId=2, DailyPrice=5, Description="Car1", ModelYear=2000},
            new Car {Id=1, BrandId=3, ColorId=3, DailyPrice=4, Description="Car2",ModelYear=2000},
            new Car {Id=1, BrandId=2, ColorId=1, DailyPrice=6, Description="Car3",ModelYear=2000},
        };
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

        public List<Car>  GetByBrandId(int brandId)
        {
            return  _cars.Where(c => c.BrandId == brandId).ToList();
            
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = 10;
        }
    }
}
