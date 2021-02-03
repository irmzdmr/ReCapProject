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
                new Car{Id=1, BrandId=1, ColorId=1 , Modelyear=2019, DailyPrice=600000, Description= "Audi A5" },
                new Car{Id=2, BrandId=2, ColorId=2 , Modelyear=2006, DailyPrice=50000, Description= "Renault Clio" },
                new Car{Id=3, BrandId=1, ColorId=2 , Modelyear=2016, DailyPrice=630000, Description= "Audi Q3" },
                new Car{Id=4, BrandId=3, ColorId=3 , Modelyear=2007, DailyPrice=90000, Description= "Toyota Corolla" },
                new Car{Id=5, BrandId=3, ColorId=1 , Modelyear=2018, DailyPrice=260000, Description= "Toyota Camry" },
                new Car{Id=6, BrandId=4, ColorId=1 , Modelyear=2021, DailyPrice=2000000, Description= "Volvo XC90" }




            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Modelyear = car.Modelyear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
