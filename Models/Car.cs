using System;

namespace Parking.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string LicensePlate { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime DepartureTime { get; set; }
    }
}