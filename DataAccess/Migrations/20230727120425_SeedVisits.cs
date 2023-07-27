using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedVisits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Visits",
                columns: new[] { "Id", "AnimalId", "Details", "VetId", "VisitDateTime" },
                values: new object[,]
                {
                    { 1, 1, null, 1, new DateTime(2023, 1, 13, 13, 45, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, null, 1, new DateTime(2023, 7, 11, 11, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, null, 1, new DateTime(2023, 6, 12, 11, 13, 10, 0, DateTimeKind.Unspecified) },
                    { 4, 4, null, 2, new DateTime(2023, 6, 14, 11, 10, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visits",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 48, 39, 857, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 48, 39, 857, DateTimeKind.Local).AddTicks(9227), new DateTime(2023, 7, 27, 10, 48, 39, 857, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 48, 39, 861, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 48, 39, 861, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 48, 39, 861, DateTimeKind.Local).AddTicks(4883), new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 48, 39, 861, DateTimeKind.Utc).AddTicks(4890));
        }
    }
}
