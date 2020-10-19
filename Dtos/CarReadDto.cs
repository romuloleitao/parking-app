namespace Parking.Dtos
{
    public class CarReadDto
    {
        public int Id { get; set; }

        public string TypeName { get; set; }

        public string LicensePlate { get; set; }

        public string EntryTime { get; set; }

        public string DepartureTime { get; set; }
    }
}