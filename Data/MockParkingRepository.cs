using System;
using System.Collections.Generic;
using Parking.Models;

namespace Parking.Data
{
    public class MockParkingRepository : IParkingRepository
    {
        public IEnumerable<Car> GetAllCars()
        {
            var cars = new List<Car>
            {
                new Car{Id=0, TypeName="Honda CRV", EntryTime=DateTime.Now, DepartureTime=DateTime.Now},
                new Car{Id=1, TypeName="Toyota Camry", EntryTime=DateTime.Now, DepartureTime=DateTime.Now},
                new Car{Id=2, TypeName="Toyota Corolla", EntryTime=DateTime.Now, DepartureTime=DateTime.Now},
                new Car{Id=3, TypeName="Ford Focus", EntryTime=DateTime.Now, DepartureTime=DateTime.Now},
            };

            return cars;
        }

        public Car GetCarById(int id)
        {
            return new Car { Id = 0, TypeName = "Honda CRV", EntryTime = DateTime.Now, DepartureTime = DateTime.Now };
        }
    }
}