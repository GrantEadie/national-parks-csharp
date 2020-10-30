using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reserves",
                columns: new[] { "ReserveId", "ReserveName" },
                values: new object[,]
                {
                    { 1, "North Cascades National Park" },
                    { 2, "Mt. Hood NationalForest" },
                    { 3, "Zion National Park" },
                    { 4, "Yosemite National Park" },
                    { 5, "Yellowstone National Park" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "StateName" },
                values: new object[,]
                {
                    { 1, "Washington" },
                    { 2, "Oregon" },
                    { 3, "Utah" },
                    { 4, "California" },
                    { 5, "Montana" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reserves",
                keyColumn: "ReserveId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reserves",
                keyColumn: "ReserveId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reserves",
                keyColumn: "ReserveId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reserves",
                keyColumn: "ReserveId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reserves",
                keyColumn: "ReserveId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5);
        }
    }
}
