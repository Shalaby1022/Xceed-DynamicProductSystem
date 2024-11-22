using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
    new Product
    {
        Id = 1,
        Title = "Fortune of Time",
        Author = "Billy Spark",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.",
        ISBN = "SWD9999001",
        ListPrice = 99,
        Price = 90,
        Price50 = 85,
        Price100 = 80,
        CategoryId = 1,
        CreationDate = new DateTime(2024, 1, 1),
        CreatedByUserId = "admin",
        StartDate = new DateTime(2024, 1, 15),
        Duration = new TimeSpan(30, 0, 0, 0), // 30 days
         ImageUrl = ""
    },
    new Product
    {
        Id = 2,
        Title = "Dark Skies",
        Author = "Nancy Hoover",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.",
        ISBN = "CAW777777701",
        ListPrice = 40,
        Price = 30,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 1,
        CreationDate = new DateTime(2024, 1, 2),
        CreatedByUserId = "editor",
        StartDate = new DateTime(2024, 1, 20),
        Duration = new TimeSpan(60, 0, 0, 0), // 60 days
        ImageUrl = ""
    },
    new Product
    {
        Id = 3,
        Title = "Vanish in the Sunset",
        Author = "Julian Button",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.",
        ISBN = "RITO5555501",
        ListPrice = 55,
        Price = 50,
        Price50 = 40,
        Price100 = 35,
        CategoryId = 1,
        CreationDate = new DateTime(2024, 1, 3),
        CreatedByUserId = "author",
        StartDate = new DateTime(2024, 1, 25),
        Duration = new TimeSpan(90, 0, 0, 0), // 90 days
        ImageUrl = ""
    },
    new Product
    {
        Id = 4,
        Title = "Cotton Candy",
        Author = "Abby Muscles",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.",
        ISBN = "WS3333333301",
        ListPrice = 70,
        Price = 65,
        Price50 = 60,
        Price100 = 55,
        CategoryId = 2,
        CreationDate = new DateTime(2024, 1, 4),
        CreatedByUserId = "reviewer",
        StartDate = new DateTime(2024, 1, 30),
        Duration = new TimeSpan(120, 0, 0, 0), // 120 days
        ImageUrl = ""
    },
    new Product
    {
        Id = 5,
        Title = "Rock in the Ocean",
        Author = "Ron Parker",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.",
        ISBN = "SOTJ1111111101",
        ListPrice = 30,
        Price = 27,
        Price50 = 25,
        Price100 = 20,
        CategoryId = 2,
        CreationDate = new DateTime(2024, 1, 5),
        CreatedByUserId = "editor",
        StartDate = new DateTime(2024, 2, 1),
        Duration = new TimeSpan(150, 0, 0, 0) ,// 150 days
         ImageUrl = ""
    },
    new Product
    {
        Id = 6,
        Title = "Leaves and Wonders",
        Author = "Laura Phantom",
        Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt.",
        ISBN = "FOT000000001",
        ListPrice = 25,
        Price = 23,
        Price50 = 22,
        Price100 = 20,
        CategoryId = 3,
        CreationDate = new DateTime(2024, 1, 6),
        CreatedByUserId = "admin",
        StartDate = new DateTime(2024, 2, 5),
        Duration = new TimeSpan(180, 0, 0, 0),// 180 days
        ImageUrl = ""
        
    });



        }
    }
}
