using System.Collections.Generic;
using Parking.Models;

namespace Parking.Data
{
    public interface IParkingRepository
    {
        bool SaveChanges();
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int id);
        void CreateCar(Car car);
    }
}