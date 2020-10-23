using System;
using System.Collections.Generic;
using Parking.Models;

namespace Parking.Data
{
    public class MockParkingRepository : IParkingRepository
    {
        public void CreateCar(Car car)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAllCars()
        {
            var cars = new List<Car>
            {
                new Car{
                    Id=0,
                    TypeName="Honda CRV",
                    LicensePlate="MGH458",
                    EntryTime=DateTime.Now.ToString("HH:mm"),
                    DepartureTime=DateTime.Now.ToString("HH:mm")
                },
                new Car{
                    Id=1,
                    TypeName="Toyota Camry",
                    LicensePlate="NHK526",
                    EntryTime=DateTime.Now.ToString("HH:mm"),
                    DepartureTime=DateTime.Now.ToString("HH:mm")
                },
                new Car{
                    Id=2,
                    TypeName="Toyota Corolla",
                    LicensePlate="KOL258",
                    EntryTime=DateTime.Now.ToString("HH:mm"),
                DepartureTime=DateTime.Now.ToString("HH:mm")
                },
                new Car{
                    Id=3,
                    TypeName="Ford Focus",
                    LicensePlate="JHG478",
                    EntryTime=DateTime.Now.ToString("HH:mm"),
                    DepartureTime=DateTime.Now.ToString("HH:mm")
                },
            };

            return cars;
        }

        public Car GetCarById(int id)
        {
            return new Car
            {
                Id = 0,
                TypeName = "Honda CRV",
                LicensePlate = "MGH458",
                EntryTime = DateTime.Now.ToString("HH:mm"),
                DepartureTime = DateTime.Now.ToString("HH:mm")
            };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}