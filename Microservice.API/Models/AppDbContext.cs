using Microsoft.EntityFrameworkCore;

namespace Microservice.API.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Order> Orders { get; set; } = default!;
    }
}