using System.Collections.Generic;
using LotsAPI.Models;

namespace LotsAPI.Abstractions
{
    public interface ICarRepo
    {
        IEnumerable<CarModel> GetAllCars();
        public int AddNewCar(CarModel car, string plate);
        CarModel GetCarByPlate(string plate);
        void UpdateCar();
        void DeleteCar(string plate);
        
    } 
}