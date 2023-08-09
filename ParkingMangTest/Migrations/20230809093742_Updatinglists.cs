using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParkingMangTest.Migrations
{
    public partial class Updatinglists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "subscriberId",
                table: "subscriptions",
                newName: "SubscribersId");

            migrationBuilder.CreateIndex(
                name: "IX_subscriptions_SubscribersId",
                table: "subscriptions",
                column: "SubscribersId");

            migrationBuilder.AddForeignKey(
                name: "FK_subscriptions_subscribers_SubscribersId",
                table: "subscriptions",
                column: "SubscribersId",
                principalTable: "subscribers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_subscriptions_subscribers_SubscribersId",
                table: "subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_subscriptions_SubscribersId",
                table: "subscriptions");

            migrationBuilder.RenameColumn(
                name: "SubscribersId",
                table: "subscriptions",
                newName: "subscriberId");
        }
    }
}
