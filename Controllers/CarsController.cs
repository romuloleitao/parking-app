using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Parking.Data;
using Parking.Dtos;
using Parking.Models;

namespace Parking.Controllers
{
    //api/cars
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IParkingRepository _parkingRepository;
        private readonly IMapper _mapper;

        public CarsController(IParkingRepository parkingRepository, IMapper mapper)
        {
            _parkingRepository = parkingRepository;
            _mapper = mapper;
        }

        //GET api/cars
        [HttpGet]
        public ActionResult<IEnumerable<CarReadDto>> GetAllCars()
        {
            var cars = _parkingRepository.GetAllCars();
            return Ok(_mapper.Map<IEnumerable<CarReadDto>>(cars));
        }

        //GET api/cars/{id}
        [HttpGet("{id}", Name="GetCarById")]
        public ActionResult<CarReadDto> GetCarById(int id)
        {
            var car = _parkingRepository.GetCarById(id);

            if (car != null)
            {
                return Ok(_mapper.Map<CarReadDto>(car));
            }

            return NotFound();
        }

        //POST api/cars
        [HttpPost]
        public ActionResult <CarReadDto> CreateCar(CarCreateDto carCreateDto)
        {
            var carModel = _mapper.Map<Car>(carCreateDto);
            _parkingRepository.CreateCar(carModel);
            _parkingRepository.SaveChanges();

            var carReadDto = _mapper.Map<CarReadDto>(carModel);

            return CreatedAtRoute(nameof(GetCarById), new {Id = carReadDto.Id}, carReadDto);
        }
    }
}
