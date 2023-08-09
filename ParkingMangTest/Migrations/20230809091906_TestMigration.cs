using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ParkingMangTest.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dailylogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<int>(type: "integer", nullable: false),
                    subscriptionId = table.Column<int>(type: "integer", nullable: false),
                    checkIn = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    checkOut = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    DailyLogsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dailylogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dailylogs_dailylogs_DailyLogsId",
                        column: x => x.DailyLogsId,
                        principalTable: "dailylogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "parkingspots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    reservedSpots = table.Column<int>(type: "integer", nullable: false),
                    freeSpots = table.Column<int>(type: "integer", nullable: false),
                    totalSpots = table.Column<int>(type: "integer", nullable: false),
                    ParkingSpotsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parkingspots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_parkingspots_parkingspots_ParkingSpotsId",
                        column: x => x.ParkingSpotsId,
                        principalTable: "parkingspots",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "priceweekdays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    hourlyRate = table.Column<int>(type: "integer", nullable: false),
                    dailyRate = table.Column<int>(type: "integer", nullable: false),
                    minimumHours = table.Column<int>(type: "integer", nullable: false),
                    PriceWeekdaysId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priceweekdays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_priceweekdays_priceweekdays_PriceWeekdaysId",
                        column: x => x.PriceWeekdaysId,
                        principalTable: "priceweekdays",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "priceweekend",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    hourlyRate = table.Column<int>(type: "integer", nullable: false),
                    dailyRate = table.Column<int>(type: "integer", nullable: false),
                    minimumHours = table.Column<int>(type: "integer", nullable: false),
                    PriceWeekendId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priceweekend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_priceweekend_priceweekend_PriceWeekendId",
                        column: x => x.PriceWeekendId,
                        principalTable: "priceweekend",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subscribers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    firstName = table.Column<string>(type: "text", nullable: false),
                    lastName = table.Column<string>(type: "text", nullable: false),
                    cardNumberId = table.Column<int>(type: "integer", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phoneNumber = table.Column<string>(type: "text", nullable: false),
                    birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    plateNumber = table.Column<string>(type: "text", nullable: false),
                    SubscribersId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscribers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subscribers_subscribers_SubscribersId",
                        column: x => x.SubscribersId,
                        principalTable: "subscribers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<int>(type: "integer", nullable: false),
                    subscriberId = table.Column<int>(type: "integer", nullable: false),
                    price = table.Column<int>(type: "integer", nullable: false),
                    startDate = table.Column<DateOnly>(type: "date", nullable: false),
                    endDate = table.Column<DateOnly>(type: "date", nullable: false),
                    SubscriptionsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_subscriptions_subscriptions_SubscriptionsId",
                        column: x => x.SubscriptionsId,
                        principalTable: "subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_dailylogs_DailyLogsId",
                table: "dailylogs",
                column: "DailyLogsId");

            migrationBuilder.CreateIndex(
                name: "IX_parkingspots_ParkingSpotsId",
                table: "parkingspots",
                column: "ParkingSpotsId");

            migrationBuilder.CreateIndex(
                name: "IX_priceweekdays_PriceWeekdaysId",
                table: "priceweekdays",
                column: "PriceWeekdaysId");

            migrationBuilder.CreateIndex(
                name: "IX_priceweekend_PriceWeekendId",
                table: "priceweekend",
                column: "PriceWeekendId");

            migrationBuilder.CreateIndex(
                name: "IX_subscribers_SubscribersId",
                table: "subscribers",
                column: "SubscribersId");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptions_SubscriptionsId",
                table: "subscriptions",
                column: "SubscriptionsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dailylogs");

            migrationBuilder.DropTable(
                name: "parkingspots");

            migrationBuilder.DropTable(
                name: "priceweekdays");

            migrationBuilder.DropTable(
                name: "priceweekend");

            migrationBuilder.DropTable(
                name: "subscribers");

            migrationBuilder.DropTable(
                name: "subscriptions");
        }
    }
}
