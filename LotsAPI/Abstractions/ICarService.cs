using LotsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsAPI.Abstractions
{
    public interface ICarService
    {
       IEnumerable<CarModel> GetAllCars();
        public int AddNewCar(CarModel car, string plate);

        CarModel GetCarByPlate(string plate);
        void UpdateCar();
        void DeleteCar(string plate);
    }
}