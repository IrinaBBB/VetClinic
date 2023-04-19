using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddAnimalImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalImages_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 15, 8, 51, 42, 315, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 15, 10, 51, 42, 315, DateTimeKind.Local).AddTicks(7164), new DateTime(2023, 4, 15, 8, 51, 42, 315, DateTimeKind.Utc).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 15, 8, 51, 42, 318, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 15, 8, 51, 42, 318, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 15, 10, 51, 42, 318, DateTimeKind.Local).AddTicks(9781), new DateTime(2023, 4, 15, 8, 51, 42, 318, DateTimeKind.Utc).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 15, 10, 51, 42, 318, DateTimeKind.Local).AddTicks(9829), new DateTime(2023, 4, 15, 8, 51, 42, 318, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 15, 10, 51, 42, 318, DateTimeKind.Local).AddTicks(9837), new DateTime(2023, 4, 15, 8, 51, 42, 318, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 15, 8, 51, 42, 318, DateTimeKind.Utc).AddTicks(9842));

            migrationBuilder.CreateIndex(
                name: "IX_AnimalImages_AnimalId",
                table: "AnimalImages",
                column: "AnimalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimalImages");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 14, 16, 51, 33, 450, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 14, 18, 51, 33, 450, DateTimeKind.Local).AddTicks(7109), new DateTime(2023, 4, 14, 16, 51, 33, 450, DateTimeKind.Utc).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 14, 18, 51, 33, 455, DateTimeKind.Local).AddTicks(3707), new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 14, 18, 51, 33, 455, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "DateRegistered" },
                values: new object[] { new DateTime(2023, 4, 14, 18, 51, 33, 455, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3782));
        }
    }
}
