using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedSpecializations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "SpeciesVet",
                columns: new[] { "SpecializationsId", "VetsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 1 },
                    { 4, 1 },
                    { 4, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SpeciesVet",
                keyColumns: new[] { "SpecializationsId", "VetsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "SpeciesVet",
                keyColumns: new[] { "SpecializationsId", "VetsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "SpeciesVet",
                keyColumns: new[] { "SpecializationsId", "VetsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "SpeciesVet",
                keyColumns: new[] { "SpecializationsId", "VetsId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "SpeciesVet",
                keyColumns: new[] { "SpecializationsId", "VetsId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 33, 10, 893, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 33, 10, 894, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 7, 27, 10, 33, 10, 894, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 33, 10, 900, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 33, 10, 900, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 7, 27, 12, 33, 10, 900, DateTimeKind.Local).AddTicks(5328), new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5332));
        }
    }
}
