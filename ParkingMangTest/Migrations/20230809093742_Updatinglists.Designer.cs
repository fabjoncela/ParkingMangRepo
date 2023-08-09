﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ParkingMngV2.EfCore;

#nullable disable

namespace ParkingMangTest.Migrations
{
    [DbContext(typeof(EF_DataContext))]
    [Migration("20230809093742_Updatinglists")]
    partial class Updatinglists
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("ParkingMngV2.EfCore.DailyLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("DailyLogsId")
                        .HasColumnType("integer");

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

                    b.HasIndex("DailyLogsId");

                    b.ToTable("dailylogs");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.ParkingSpots", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("ParkingSpotsId")
                        .HasColumnType("integer");

                    b.Property<int?>("freeSpots")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("reservedSpots")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int>("totalSpots")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParkingSpotsId");

                    b.ToTable("parkingspots");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekdays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("PriceWeekdaysId")
                        .HasColumnType("integer");

                    b.Property<int>("dailyRate")
                        .HasColumnType("integer");

                    b.Property<int>("hourlyRate")
                        .HasColumnType("integer");

                    b.Property<int>("minimumHours")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PriceWeekdaysId");

                    b.ToTable("priceweekdays");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekend", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("PriceWeekendId")
                        .HasColumnType("integer");

                    b.Property<int>("dailyRate")
                        .HasColumnType("integer");

                    b.Property<int>("hourlyRate")
                        .HasColumnType("integer");

                    b.Property<int>("minimumHours")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PriceWeekendId");

                    b.ToTable("priceweekend");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscribers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int?>("SubscribersId")
                        .HasColumnType("integer");

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

                    b.HasIndex("SubscribersId");

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

                    b.Property<int?>("SubscriptionsId")
                        .HasColumnType("integer");

                    b.Property<int>("code")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("endDate")
                        .HasColumnType("date");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("startDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("SubscribersId");

                    b.HasIndex("SubscriptionsId");

                    b.ToTable("subscriptions");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.DailyLogs", b =>
                {
                    b.HasOne("ParkingMngV2.EfCore.DailyLogs", null)
                        .WithMany("dailylogs")
                        .HasForeignKey("DailyLogsId");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.ParkingSpots", b =>
                {
                    b.HasOne("ParkingMngV2.EfCore.ParkingSpots", null)
                        .WithMany("parkingSpots")
                        .HasForeignKey("ParkingSpotsId");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekdays", b =>
                {
                    b.HasOne("ParkingMngV2.EfCore.PriceWeekdays", null)
                        .WithMany("priceweekdays")
                        .HasForeignKey("PriceWeekdaysId");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekend", b =>
                {
                    b.HasOne("ParkingMngV2.EfCore.PriceWeekend", null)
                        .WithMany("priceweekend")
                        .HasForeignKey("PriceWeekendId");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscribers", b =>
                {
                    b.HasOne("ParkingMngV2.EfCore.Subscribers", null)
                        .WithMany("subscribers")
                        .HasForeignKey("SubscribersId");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscriptions", b =>
                {
                    b.HasOne("ParkingMngV2.EfCore.Subscribers", "Subscribers")
                        .WithMany()
                        .HasForeignKey("SubscribersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ParkingMngV2.EfCore.Subscriptions", null)
                        .WithMany("subscriptions")
                        .HasForeignKey("SubscriptionsId");

                    b.Navigation("Subscribers");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.DailyLogs", b =>
                {
                    b.Navigation("dailylogs");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.ParkingSpots", b =>
                {
                    b.Navigation("parkingSpots");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekdays", b =>
                {
                    b.Navigation("priceweekdays");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.PriceWeekend", b =>
                {
                    b.Navigation("priceweekend");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscribers", b =>
                {
                    b.Navigation("subscribers");
                });

            modelBuilder.Entity("ParkingMngV2.EfCore.Subscriptions", b =>
                {
                    b.Navigation("subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
