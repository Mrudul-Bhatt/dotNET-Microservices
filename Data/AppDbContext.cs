using dotNET_Microservices.Models;
using Microsoft.EntityFrameworkCore;

namespace dotNET_Microservices.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Platform> Platforms { get; set; }
    }
}