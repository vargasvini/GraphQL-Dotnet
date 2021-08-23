using Microsoft.EntityFrameworkCore;
using Rest.API.Models;

namespace Rest.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}