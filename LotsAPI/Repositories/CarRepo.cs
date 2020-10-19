using System;
using System.Collections.Generic;
using System.Linq;
using LotsAPI.Abstractions;
using LotsAPI.Infrastructure;
using LotsAPI.Models;

namespace LotsAPI.Repositories
{

    public class CarRepo : ICarRepo
    {
        private readonly LotsDbContext context;

        public CarRepo(LotsDbContext ctx)
        {
            context = ctx;

        }
        public int AddNewCar(CarModel car, string plate)
        {
            DateTime localDate = DateTime.Now;

            car.Plate = plate;
            car.Created_At = localDate;

            context.Cars.Add(car);
            context.SaveChanges();
            return car.IdCar;
        }

        public void DeleteCar(string plate)
        {
            var entity = context.Cars.First(u => u.Plate == plate);
            context.Cars.Remove(entity);
            context.SaveChanges();   
        }

        public IEnumerable<CarModel> GetAllCars()
        {
            return context.Cars.ToList();
        }

        public CarModel GetCarByPlate(string plate)
        {
            return context.Cars.FirstOrDefault(u => u.Plate == plate);
        }

        public void UpdateCar()
        {
            throw new System.NotImplementedException();
        }
    }
}