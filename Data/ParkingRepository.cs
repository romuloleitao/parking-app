using System;
using System.Collections.Generic;
using System.Linq;
using Parking.Models;

namespace Parking.Data
{
    public class ParkingRepository : IParkingRepository
    {
        private readonly ParkingContext _context;

        public ParkingRepository(ParkingContext context)
        {
            _context = context;
        }

        public void CreateCar(Car car)
        {
            if(car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            _context.Cars.Add(car);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public Car GetCarById(int id)
        {
            return _context.Cars.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}