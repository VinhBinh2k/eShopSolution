using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class updateDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "ad99df53-d733-4e26-803d-c5b22fc30689");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Dob", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "b4ec4047-38c3-4b22-bdaa-5e9c7781edad", new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenvinhbinh18@gmail.com", "Bình", "Vĩnh", "nguyenvinhbinh18@gmail.com", "AQAAAAEAACcQAAAAEABqKV+lF8XDSbGiPMLRCznZSkYSLNRR0ub7UW9EcMx7ZAatx7nLx8C+u9+TV+qXFA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 30, 21, 39, 20, 787, DateTimeKind.Local).AddTicks(1922));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "12a35688-5558-4c57-8469-36f461957ab1");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Dob", "Email", "FirstName", "LastName", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "f248cdbd-8c40-457e-b6bd-67ca5226383e", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", "Toan", "Bach", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEHIoQR2LZYLYTGgCb19jCC4x/XlxvfkUL6WAwMqxh9geWH+Y4oftzvMkUcL2Bc0omg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 4, 30, 21, 33, 34, 312, DateTimeKind.Local).AddTicks(2440));
        }
    }
}
