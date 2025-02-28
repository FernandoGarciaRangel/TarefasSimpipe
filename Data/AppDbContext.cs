using Microsoft.EntityFrameworkCore;
using SimCloudTest.Models;

namespace SimCloudTest.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; } = null!;
    }
}
