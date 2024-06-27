﻿using Microsoft.EntityFrameworkCore;
using Razor_temp.Models;

namespace Razor_temp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Repair", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Maintenance", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Add Products", DisplayOrder = 3 }
                );
        }
    }
}
}
