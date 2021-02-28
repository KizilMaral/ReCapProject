using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class İnMemoryCarDal:ICarDal
    {
        List<Car> _carDal;
        public İnMemoryCarDal()
        {
            _carDal = new List<Car> {new Car() {Id = 1,BrandId = 1,ColorId = 123,DailyPrice = 100,ModelYear = 2013,Description = "Temizzzzz" },
            new Car() {Id = 1,BrandId = 1,ColorId = 123,DailyPrice = 100,ModelYear = 2013,Description = "Temizzzzz" },
            new Car() {Id = 2,BrandId = 2,ColorId = 321,DailyPrice = 200,ModelYear = 2010,Description = "Sağlam" },
            new Car() {Id = 3,BrandId = 1,ColorId = 231,DailyPrice = 50,ModelYear = 2005,Description = "Makbul" },
            new Car() {Id = 4,BrandId = 3,ColorId = 312,DailyPrice = 150,ModelYear = 2015,Description = "Öğretmenden" }};
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carDal.SingleOrDefault(p => p.Id == car.Id);
            _carDal.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> Filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDal;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> Filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _carDal.SingleOrDefault(p => p.Id == Id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToDelete = _carDal.SingleOrDefault(p => p.Id == car.Id);
            carToDelete.Id = car.Id;
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.Description = car.Description;

        }
    }
}
