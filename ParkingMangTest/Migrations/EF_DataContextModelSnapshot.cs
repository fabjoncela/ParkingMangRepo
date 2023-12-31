﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ParkingMngV2.EfCore;

#nullable disable

namespace ParkingMangTest.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    partial class EF_DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("ParkingMngV2.EfCore.DailyLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("checkIn")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("checkOut")
                        .HasColumnType("time without time zone");

                    b.Property<int>("code")
                        .HasColumnType("integer");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<int>("subscriptionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("dailylogs");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.ParkingSpots", b =>
                {
                    b.Property<int>("ParkingSpotsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("ParkingSpotsId"));

                    b.Property<int?>("freeSpots")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("reservedSpots")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int>("totalSpots")
                        .HasColumnType("integer");

                    b.HasKey("ParkingSpotsId");

                    b.ToTable("parkingspots");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekdays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("dailyRate")
                        .HasColumnType("integer");

                    b.Property<int>("hourlyRate")
                        .HasColumnType("integer");

                    b.Property<int>("minimumHours")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("priceweekdays");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("dailyRate")
                        .HasColumnType("integer");

                    b.Property<int>("hourlyRate")
                        .HasColumnType("integer");

                    b.Property<int>("minimumHours")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("priceweekend");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscribers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("birthday")
                        .HasColumnType("date");

                    b.Property<int>("cardNumberId")
                        .HasColumnType("integer");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("plateNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("subscribers");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscriptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("SubscribersId")
                        .HasColumnType("integer");

                    b.Property<int>("code")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("endDate")
                        .HasColumnType("date");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("startDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("SubscribersId");

                    b.ToTable("subscriptions");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscriptions", b =>
                {
                    b.HasOne("ParkingMngV2.EfCore.Subscribers", "Subscribers")
                        .WithMany()
                        .HasForeignKey("SubscribersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscribers");
                });
#pragma warning restore 612, 618
        }
    }
}
