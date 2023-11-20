using Proniam.Models;
using Microsoft.EntityFrameworkCore;

namespace Proniam.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Slides> Slides { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}