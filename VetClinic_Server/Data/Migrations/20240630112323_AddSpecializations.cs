using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VetClinic_Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecializations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Specialization",
                table: "Vets");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Vets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasEmergencyCertification",
                table: "Vets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SpecializationId",
                table: "Vets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Specializes in performing surgical procedures on animals, including orthopedic, soft tissue, and minimally invasive surgeries.", "Veterinary Surgery" },
                    { 2, "Specializes in dental care for animals, including oral surgery, cleanings, and treatments for dental diseases.", "Veterinary Dentistry" },
                    { 3, "Focuses on the diagnosis and treatment of diseases and injuries in pets like dogs and cats.", "Small Animal Medicine and Surgery" },
                    { 4, "Focuses on the diagnosis and treatment of diseases and injuries in pets like dogs and cats.", "Exotic Animal Medicine" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vets_SpecializationId",
                table: "Vets",
                column: "SpecializationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vets_Specializations_SpecializationId",
                table: "Vets",
                column: "SpecializationId",
                principalTable: "Specializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vets_Specializations_SpecializationId",
                table: "Vets");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropIndex(
                name: "IX_Vets_SpecializationId",
                table: "Vets");

            migrationBuilder.DropColumn(
                name: "Available",
                table: "Vets");

            migrationBuilder.DropColumn(
                name: "HasEmergencyCertification",
                table: "Vets");

            migrationBuilder.DropColumn(
                name: "SpecializationId",
                table: "Vets");

            migrationBuilder.AddColumn<string>(
                name: "Specialization",
                table: "Vets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
