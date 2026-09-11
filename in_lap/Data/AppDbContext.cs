using in_lap.Models;
using Microsoft.EntityFrameworkCore;

namespace in_lap.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }







    }
}
