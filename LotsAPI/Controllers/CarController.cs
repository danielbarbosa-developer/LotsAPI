using System.Collections.Generic;
using LotsAPI.Abstractions;
using LotsAPI.Models;
using Microsoft.AspNetCore.Mvc;


namespace LotsAPI.Controllers
{
    [Route("api/cars")]
    public class CarController : ControllerBase
    {
        /*
        [HttpGet]
        public ActionResult GetAll()
        {
            int[] newArray;
            newArray = new int[5] {1, 2, 3, 4, 5};
            return Ok(newArray);
        }
        */
        private readonly ICarService carService;
        public CarController(ICarService carServ)
        {
            carService = carServ;
        }
        [HttpGet]
       public ActionResult<IEnumerable<CarModel>> GetAll()
        {
            if(carService.GetAllCars() == null)
            {
                return NotFound();
            }
            return Ok(carService.GetAllCars());
        }

        [HttpPost]
        public ActionResult<int> Add(CarModel car, string plate)
        {
            if(plate == null)
                return BadRequest();
            return carService.AddNewCar(car, plate);
        }

        [HttpGet ("{plate}")]
         public ActionResult GetByPlate(string plate)
        {
            var car = carService.GetCarByPlate(plate);
            if (car == null)
                return NotFound();

            return Ok(car);
        }
        
    }
}