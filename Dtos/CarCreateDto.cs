namespace Parking.Dtos
{
    public class CarCreateDto
    {
        public string TypeName { get; set; }

        public string LicensePlate { get; set; }

        public string EntryTime { get; set; }

        public string DepartureTime { get; set; }
    }
}