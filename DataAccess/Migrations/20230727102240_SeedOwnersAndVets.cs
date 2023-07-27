using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedOwnersAndVets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "Age", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 33, "annamari@uit.no", "Anna Mari Larsen" },
                    { 2, 42, "kris@uit.no", "Kris Iversen" }
                });

            migrationBuilder.InsertData(
                table: "Vets",
                columns: new[] { "Id", "Age", "DateOfGraduation", "Name" },
                values: new object[,]
                {
                    { 1, 33, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kjartan Olsen" },
                    { 2, 27, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sofia Andersen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vets",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
