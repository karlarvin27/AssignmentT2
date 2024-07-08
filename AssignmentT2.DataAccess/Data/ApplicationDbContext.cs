using AssignmentT2.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentT2.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Repair", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Maintenance", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Add Products", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                Id = 1,
                Services = "PMS",
                Description = "Maintenance",
                ListPrice = 50,
                Price = 50,
                Price3 = 45,
                Price5 = 40,
                CategoryId = 1,
                ImageUrl=""

                },
                new Product
                {
                Id = 2,
                Services = "Tire Services",
                Description = "Tire Services",
                ListPrice = 100,
                Price = 100,
                Price3 = 90,
                Price5 = 80,
                CategoryId= 2,
                ImageUrl = ""


                },
                new Product
                {
                Id = 3,
                Services = "Auto Repair",
                Description = "Repairs for cars",
                ListPrice = 1000,
                Price = 1000,
                Price3 = 980,
                Price5 = 940,
                CategoryId = 3,
                ImageUrl = ""
                }


                );
        }
    }
}