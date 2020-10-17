using Microsoft.EntityFrameworkCore;
using Parking.Models;

namespace Parking.Data
{
    public class ParkingContext : DbContext
    {
        public ParkingContext(DbContextOptions<ParkingContext> options) : base(options)
        {
            
        }

        public DbSet<Car> Cars { get; set; }
    }
}