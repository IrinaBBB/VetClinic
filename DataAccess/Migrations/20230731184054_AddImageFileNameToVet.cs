using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddImageFileNameToVet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Vets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 31, 18, 40, 53, 199, DateTimeKind.Utc).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 31, 20, 40, 53, 200, DateTimeKind.Local).AddTicks(1212), new DateTime(2023, 7, 31, 18, 40, 53, 200, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 31, 18, 40, 53, 203, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 31, 18, 40, 53, 203, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 31, 20, 40, 53, 203, DateTimeKind.Local).AddTicks(6932), new DateTime(2023, 7, 31, 18, 40, 53, 203, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 31, 20, 40, 53, 203, DateTimeKind.Local).AddTicks(7028), new DateTime(2023, 7, 31, 18, 40, 53, 203, DateTimeKind.Utc).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 31, 20, 40, 53, 203, DateTimeKind.Local).AddTicks(7042), new DateTime(2023, 7, 31, 18, 40, 53, 203, DateTimeKind.Utc).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 31, 18, 40, 53, 203, DateTimeKind.Utc).AddTicks(7048));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Vets");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 12, 4, 24, 231, DateTimeKind.Utc).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 4, 24, 231, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 7, 27, 12, 4, 24, 231, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 12, 4, 24, 235, DateTimeKind.Utc).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 12, 4, 24, 235, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 4, 24, 235, DateTimeKind.Local).AddTicks(9671), new DateTime(2023, 7, 27, 12, 4, 24, 235, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 4, 24, 235, DateTimeKind.Local).AddTicks(9742), new DateTime(2023, 7, 27, 12, 4, 24, 235, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 14, 4, 24, 235, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 7, 27, 12, 4, 24, 235, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 12, 4, 24, 235, DateTimeKind.Utc).AddTicks(9756));
        }
    }
}
