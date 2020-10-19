using System.Collections.Generic;
using LotsAPI.Models;
using LotsAPI.Abstractions;


namespace LotsAPI.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepo carRepo;
        public CarService(ICarRepo carRepository)
        {
            carRepo = carRepository;
        }

        public int AddNewCar(CarModel car, string plate)
        {
            return carRepo.AddNewCar(car, plate);
        }

        public void DeleteCar(string plate)
        {
            carRepo.DeleteCar(plate);
        }

        public IEnumerable<CarModel> GetAllCars()
        {
            return carRepo.GetAllCars();
        }

        public CarModel GetCarByPlate(string plate)
        {
            return carRepo.GetCarByPlate(plate);
        }

        public void UpdateCar()
        {
            throw new System.NotImplementedException();
        }
    }
}