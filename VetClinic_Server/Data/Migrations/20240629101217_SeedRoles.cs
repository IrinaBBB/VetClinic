using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetClinic_Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b51ab51-d0d9-44e1-a9e1-f0fab3563f00", null, "Admin", "ADMIN" },
                    { "38e1428b-c734-4130-830b-5bce7ab8ed38", null, "Vet", "VET" },
                    { "f7e975ec-6546-4e14-809f-585f2446eae9", null, "Owner", "OWNER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b51ab51-d0d9-44e1-a9e1-f0fab3563f00");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38e1428b-c734-4130-830b-5bce7ab8ed38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7e975ec-6546-4e14-809f-585f2446eae9");
        }
    }
}
