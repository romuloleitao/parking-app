using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parking.Data;
using Parking.Models;

namespace Parking.Controllers
{
    //api/cars
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IParkingRepository _parkingRepository;

        // private readonly MockParkingRepository _mockParkingRepository = new MockParkingRepository();
        public CarsController(IParkingRepository parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }

        //GET api/cars
        [HttpGet]
        public ActionResult <IEnumerable<Car>> GetAllCars()
        {
            var cars = _parkingRepository.GetAllCars();
            return Ok(cars);
        }

        //GET api/cars/{id}
        [HttpGet("{id}")]
        public ActionResult <Car> GetCarById(int id)
        {
            var car = _parkingRepository.GetCarById(id);
            return Ok(car);
        }
    }
}