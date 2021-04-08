﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_Data;

namespace Restaurant_Data.Migrations
{
    [DbContext(typeof(RestaurantDbContext))]
    [Migration("20210408125432_DatabaseRelationsTest1")]
    partial class DatabaseRelationsTest1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurant_Core.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderProductsId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderProductsId1")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderProductsId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Restaurant_Core.OrderProducts", b =>
                {
                    b.Property<int>("OrderProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DrinksReady")
                        .HasColumnType("bit");

                    b.Property<bool>("FoodReady")
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("OrderProductsId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Restaurant_Core.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FoodType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderProductsId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("OrderProductsId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            FoodType = 3,
                            Name = "Spaghetti",
                            Price = 20.0
                        },
                        new
                        {
                            ProductId = 2,
                            FoodType = 3,
                            Name = "Lasagne",
                            Price = 25.0
                        });
                });

            modelBuilder.Entity("Restaurant_Core.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DinnerOrLunch")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Restaurant_Core.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<bool>("Occupied")
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 2,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 3,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 4,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 5,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 6,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 7,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 8,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 9,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 10,
                            AvailableSeats = 4,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 11,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 12,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 13,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 14,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 15,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 16,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 17,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 18,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 19,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 20,
                            AvailableSeats = 2,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 21,
                            AvailableSeats = 6,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 22,
                            AvailableSeats = 6,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 23,
                            AvailableSeats = 6,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 24,
                            AvailableSeats = 6,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 25,
                            AvailableSeats = 6,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 26,
                            AvailableSeats = 6,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 27,
                            AvailableSeats = 8,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        },
                        new
                        {
                            TableId = 28,
                            AvailableSeats = 8,
                            Occupied = false,
                            OrderId = 0,
                            ReservationId = 0
                        });
                });

            modelBuilder.Entity("Restaurant_Core.Order", b =>
                {
                    b.HasOne("Restaurant_Core.OrderProducts", "OrderProducts")
                        .WithMany()
                        .HasForeignKey("OrderProductsId1");

                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("Restaurant_Core.Product", b =>
                {
                    b.HasOne("Restaurant_Core.OrderProducts", null)
                        .WithMany("ProductsInOrder")
                        .HasForeignKey("OrderProductsId");
                });

            modelBuilder.Entity("Restaurant_Core.Table", b =>
                {
                    b.HasOne("Restaurant_Core.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant_Core.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Restaurant_Core.OrderProducts", b =>
                {
                    b.Navigation("ProductsInOrder");
                });
#pragma warning restore 612, 618
        }
    }
}
