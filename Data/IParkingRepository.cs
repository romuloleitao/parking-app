using System.Collections.Generic;
using Parking.Models;

namespace Parking.Data
{
    public interface IParkingRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
    }
}