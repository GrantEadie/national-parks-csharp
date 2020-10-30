using Microsoft.EntityFrameworkCore.Migrations;

namespace NationalParkApi.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StateReserves",
                columns: new[] { "StateReserveId", "ReserveId", "StateId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateReserves",
                keyColumn: "StateReserveId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateReserves",
                keyColumn: "StateReserveId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateReserves",
                keyColumn: "StateReserveId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateReserves",
                keyColumn: "StateReserveId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateReserves",
                keyColumn: "StateReserveId",
                keyValue: 5);
        }
    }
}
