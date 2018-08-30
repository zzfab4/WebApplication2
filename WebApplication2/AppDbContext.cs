using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class AppDbContext : DbContext
    {
        private static DbContextOptions options;

        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}