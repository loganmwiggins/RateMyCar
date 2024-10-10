﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RateMyCar.Data;

#nullable disable

namespace RateMyCar.Migrations
{
    [DbContext(typeof(CarDbContext))]
    [Migration("20241010175715_CarDataAndChangeToUser")]
    partial class CarDataAndChangeToUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RateMyCar.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("car_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CarId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("category");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("make");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("model");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.HasKey("CarId");

                    b.ToTable("car");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            Category = "SUV",
                            Make = "Toyota",
                            Model = "Rav 4",
                            Year = 2017
                        },
                        new
                        {
                            CarId = 2,
                            Category = "Sedan",
                            Make = "Toyota",
                            Model = "Supra",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 3,
                            Category = "Truck",
                            Make = "Toyota",
                            Model = "Tundra",
                            Year = 2018
                        },
                        new
                        {
                            CarId = 4,
                            Category = "SUV",
                            Make = "Toyota",
                            Model = "4 Runner",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 5,
                            Category = "Truck",
                            Make = "Toyota",
                            Model = "Tacoma",
                            Year = 2022
                        },
                        new
                        {
                            CarId = 6,
                            Category = "Sedan",
                            Make = "Ford",
                            Model = "Focus",
                            Year = 2014
                        },
                        new
                        {
                            CarId = 7,
                            Category = "Sedan",
                            Make = "Honda",
                            Model = "Accord",
                            Year = 2020
                        },
                        new
                        {
                            CarId = 8,
                            Category = "Sedan",
                            Make = "Lexus",
                            Model = "LS",
                            Year = 2023
                        },
                        new
                        {
                            CarId = 9,
                            Category = "Sedan",
                            Make = "Lexus",
                            Model = "ES",
                            Year = 2025
                        },
                        new
                        {
                            CarId = 10,
                            Category = "SUV",
                            Make = "Lexus",
                            Model = "LX",
                            Year = 2024
                        },
                        new
                        {
                            CarId = 11,
                            Category = "Sedan",
                            Make = "BMW",
                            Model = "E30",
                            Year = 1995
                        });
                });

            modelBuilder.Entity("RateMyCar.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("review_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("CarId")
                        .HasColumnType("integer")
                        .HasColumnName("car_id");

                    b.Property<string>("Comments")
                        .HasColumnType("text")
                        .HasColumnName("comments");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_posted");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text")
                        .HasColumnName("photo_url");

                    b.Property<int>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<int>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("ReviewId");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("review");
                });

            modelBuilder.Entity("RateMyCar.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("email");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("full_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("RateMyCar.Models.Review", b =>
                {
                    b.HasOne("RateMyCar.Models.Car", "Car")
                        .WithMany("Reviews")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RateMyCar.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RateMyCar.Models.Car", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("RateMyCar.Models.User", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
