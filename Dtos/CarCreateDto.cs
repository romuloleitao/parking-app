using System.ComponentModel.DataAnnotations;

namespace Parking.Dtos
{
    public class CarCreateDto
    {
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