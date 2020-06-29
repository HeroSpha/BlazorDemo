﻿// <auto-generated />
using System;
using BlazorDemo.Shared.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorDemo.Shared.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20200628114534_trip")]
    partial class trip
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorDemo.Shared.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.CarTrip", b =>
                {
                    b.Property<int>("CarTripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("CarTripId");

                    b.HasIndex("CarId");

                    b.HasIndex("DriverId");

                    b.HasIndex("TripId");

                    b.ToTable("CarTrip");
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.Driver", b =>
                {
                    b.Property<int>("DriverId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverId");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.UserContact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContactType")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ContactId");

                    b.HasIndex("UserId");

                    b.ToTable("UserContacts");
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.Car", b =>
                {
                    b.HasOne("BlazorDemo.Shared.Models.User", "User")
                        .WithMany("Cars")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.CarTrip", b =>
                {
                    b.HasOne("BlazorDemo.Shared.Models.Car", "Car")
                        .WithMany("CarTrips")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorDemo.Shared.Models.Driver", "Driver")
                        .WithMany("CarTrips")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorDemo.Shared.Models.Trip", "Trip")
                        .WithMany("CarTrips")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorDemo.Shared.Models.UserContact", b =>
                {
                    b.HasOne("BlazorDemo.Shared.Models.User", "User")
                        .WithMany("UserContacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
