using Homework4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework4.Controllers
{
    public class CarsController : Controller
    {
        public List<EntityCar> _cars = DatabaseCars.Cars;

        [HttpGet] 
        [Route("api/cars")]
        public ActionResult GetAllCars()
        {
            return Ok(_cars);
        }

        [HttpGet]
        [Route("api/cars/{manufacturer}")]
        public ActionResult GetCarByManufacturer(string manufacturer)
        {
            return Ok(_cars.FindAll(x => x.Manufacturer.ToLower() == manufacturer.ToLower()));
        }

        [HttpPost]
        [Route("api/cars")]
        public ActionResult CreateNewCar([FromBody] EntityCar carEntity)
        {
            var isAlreadyACar = _cars.Any(x => x.Id == carEntity.Id);
            if (isAlreadyACar)
            {
                return BadRequest();
            }
            if (carEntity == null)
            {
                return BadRequest();
            }
            if (carEntity.Manufacturer == null)
            {
                return BadRequest();
            }
            _cars.Add(carEntity);

            return Ok(carEntity);
        }

        [HttpPut]
        [Route("api/cars/{id}")]
        public ActionResult UpdateCar(int id, [FromBody] EntityCar carEntity)
        {
            if (carEntity == null)
            {
                return BadRequest();
            }

            var car = _cars.FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            car.Model = carEntity.Model;
            car.HorsePower = carEntity.HorsePower;
            car.Manufacturer = carEntity.Manufacturer;
            car.Year = carEntity.Year;
            car.Price = carEntity.Price;

            return Ok(car);
        }

        [HttpDelete]
        [Route("api/cars/{id}")]
        public ActionResult RemoveCar(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var car = _cars.FirstOrDefault(x => x.Id == id);
            if (car == null)
            {
                return BadRequest();
            }
            _cars.Remove(car);
            return Ok();
        }

    }
}
