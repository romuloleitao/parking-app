using System.Collections.Generic;
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

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars;
        }

        public Car GetCarById(int id)
        {
            var car = _context.Cars.Find(id);
            return car;
        }
    }
}