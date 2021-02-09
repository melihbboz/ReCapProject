using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{CarId=1,BrandId=1,ColorId=323,DailyPrice=100,ModelYear=2016,Description="manuel vites sedan"},
                new Car{CarId=2,BrandId=5,ColorId=435,DailyPrice=120,ModelYear=2018,Description="otomatik vites station vagon"},
                new Car{CarId=3,BrandId=3,ColorId=231,DailyPrice=150,ModelYear=2019,Description="otomatik vites hatchback"},
                new Car{CarId=4,BrandId=7,ColorId=764,DailyPrice=90,ModelYear=2013,Description="otomatik vites sedan"},
                new Car{CarId=5,BrandId=13,ColorId=964,DailyPrice=500,ModelYear=2021,Description="manuel vites hatchback"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p=>p.CarId==carId).ToList();
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;

            
        }
    }
}
