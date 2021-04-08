using Microsoft.EntityFrameworkCore;
using Restaurant_Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1, Name = "Spaghetti", FoodType = FoodType.Main, Price = 20
                },
                new Product
                {
                    ProductId = 2, Name = "Lasagne", FoodType = FoodType.Main, Price = 25
                });

            builder.Entity<Table>().HasData(
                new Table
                {
                    TableId = 1, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 2, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 3, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 4, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 5, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 6, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 7, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 8, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 9, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 10, Occupied = false, AvailableSeats = 4
                },
                new Table
                {
                    TableId = 11, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 12, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 13, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 14, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 15, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 16, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 17, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 18, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 19, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 20, Occupied = false, AvailableSeats = 2
                },
                new Table
                {
                    TableId = 21, Occupied = false, AvailableSeats = 6
                },
                new Table
                {
                    TableId = 22, Occupied = false, AvailableSeats = 6
                },
                new Table
                {
                    TableId = 23, Occupied = false, AvailableSeats = 6
                },
                new Table
                {
                    TableId = 24, Occupied = false, AvailableSeats = 6
                },
                new Table
                {
                    TableId = 25, Occupied = false, AvailableSeats = 6
                },
                new Table
                {
                    TableId = 26, Occupied = false, AvailableSeats = 6
                },
                new Table
                {
                    TableId = 27, Occupied = false, AvailableSeats = 8
                },
                new Table
                {
                    TableId = 28, Occupied = false, AvailableSeats = 8
                });
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
