using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Neutered = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Chipped = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Sex = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    WeightInKilos = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EscapeAttempts = table.Column<int>(type: "int", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeciesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Cat is a domestic species of small carnivorous mammal.", "Cat" },
                    { 2, "Dog is is a domesticated descendant of the wolf. Also called the domestic dog, it is derived from the extinct Pleistocene wolf, and the modern wolf is the dog's nearest living relative.", "Dog" },
                    { 3, "Fish are aquatic, craniate, gill-bearing animals that lack limbs with digits. Included in this definition are the living hagfish, lampreys, and cartilaginous and bony fish as well as various extinct related groups.", "Fish" },
                    { 4, "Rodents (from Latin rodere, 'to gnaw') are mammals of the order Rodentia (/roʊˈdɛnʃə/), which are characterized by a single pair of continuously growing incisors in each of the upper and lower jaws. About 40% of all mammal species are rodents.", "Rodent" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Chipped", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "EscapeAttempts", "Name", "Neutered", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 2, 1, "Anna Bergsson", new DateTime(2023, 4, 14, 18, 51, 33, 450, DateTimeKind.Local).AddTicks(7109), new DateTime(2023, 4, 14, 16, 51, 33, 450, DateTimeKind.Utc).AddTicks(7016), null, 0, "Inka", 1, 2, 1, null, 2m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "EscapeAttempts", "Name", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 4, "Anna Bergsson", null, new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3702), null, 0, "Urshy", 1, 1, null, 5m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Chipped", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "EscapeAttempts", "Name", "Neutered", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 6, 2, "Anna Bergsson", new DateTime(2023, 4, 14, 18, 51, 33, 455, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3768), null, 0, "Jessie", 1, 2, 1, null, 2m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "EscapeAttempts", "Name", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 1, "Anna Bergsson", null, new DateTime(2023, 4, 14, 16, 51, 33, 450, DateTimeKind.Utc).AddTicks(3372), null, 0, "Lad", 1, 2, null, 3m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Chipped", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "EscapeAttempts", "Name", "Neutered", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[,]
                {
                    { 5, 2, "Anna Bergsson", new DateTime(2023, 4, 14, 18, 51, 33, 455, DateTimeKind.Local).AddTicks(3707), new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3705), null, 6, "Sebastian", 2, 1, 2, null, 9m },
                    { 7, 1, "Anna Bergsson", new DateTime(2023, 4, 14, 18, 51, 33, 455, DateTimeKind.Local).AddTicks(3778), new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3776), null, 3, "Quiffy", 1, 2, 2, null, 3m },
                    { 8, 2, "Anna Bergsson", null, new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3782), null, 0, "Woffy", 1, 1, 2, null, 4m }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "EscapeAttempts", "Name", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 3, "Anna Bergsson", null, new DateTime(2023, 4, 14, 16, 51, 33, 455, DateTimeKind.Utc).AddTicks(3674), null, 0, "Dundy", 3, null, 0m });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_SpeciesId",
                table: "Animals",
                column: "SpeciesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Species");
        }
    }
}
