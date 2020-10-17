using System;
using System.ComponentModel.DataAnnotations;

namespace Parking.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public string TypeName { get; set; }

        [Required]
        public string LicensePlate { get; set; }

        [Required]
        public string EntryTime { get; set; }

        [Required]
        public string DepartureTime { get; set; }
    }
}