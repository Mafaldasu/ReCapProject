using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2020,DailyPrice=1000,Description="Ford"},
            new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2000,DailyPrice=100,Description="Mercedes"},
            new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2010,DailyPrice=250,Description="BMW"},
            new Car{Id=4,BrandId=2,ColorId=1,ModelYear=2012,DailyPrice=400,Description="Opel"},
            new Car{Id=5,BrandId=3,ColorId=3,ModelYear=2021,DailyPrice=2000,Description="Fiat"}

            };

        }
        
        
        
        public void Add(Car car)
        {
            _cars.Add(car);
            
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int categoryId)
        {
            return _cars.Where(c => c.Id == categoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
