using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SeedAnimalsAndSpecies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Species",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Unknown" },
                    { 2, "Cat is a domestic species of small carnivorous mammal.", "Cat" },
                    { 3, "Dog is is a domesticated descendant of the wolf. Also called the domestic dog, it is derived from the extinct Pleistocene wolf, and the modern wolf is the dog's nearest living relative.", "Dog" },
                    { 4, "Fish are aquatic, craniate, gill-bearing animals that lack limbs with digits. Included in this definition are the living hagfish, lampreys, and cartilaginous and bony fish as well as various extinct related groups.", "Fish" },
                    { 5, "Rodents (from Latin rodere, 'to gnaw') are mammals of the order Rodentia (/roʊˈdɛnʃə/), which are characterized by a single pair of continuously growing incisors in each of the upper and lower jaws. About 40% of all mammal species are rodents.", "Rodent" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "Name", "OwnerId", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 1, "Anna Bergsson", null, new DateTime(2023, 7, 27, 10, 33, 10, 893, DateTimeKind.Utc).AddTicks(7466), null, "Lad", 1, 1, 2, null, 3m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Chipped", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "Name", "Neutered", "OwnerId", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 2, 1, "Anna Bergsson", new DateTime(2023, 7, 27, 12, 33, 10, 894, DateTimeKind.Local).AddTicks(2353), new DateTime(2023, 7, 27, 10, 33, 10, 894, DateTimeKind.Utc).AddTicks(2328), null, "Inka", 1, 1, 2, 2, null, 2m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "Name", "OwnerId", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 4, "Anna Bergsson", null, new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5258), null, "Urshy", 2, 1, 2, null, 5m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Chipped", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "Name", "Neutered", "OwnerId", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 6, 2, "Anna Bergsson", new DateTime(2023, 7, 27, 12, 33, 10, 900, DateTimeKind.Local).AddTicks(5321), new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5319), null, "Jessie", 1, 2, 2, 2, null, 2m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Chipped", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "EscapeAttempts", "Name", "Neutered", "OwnerId", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[,]
                {
                    { 5, 2, "Anna Bergsson", new DateTime(2023, 7, 27, 12, 33, 10, 900, DateTimeKind.Local).AddTicks(5263), new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5261), null, 6, "Sebastian", 2, 2, 1, 3, null, 9m },
                    { 7, 1, "Anna Bergsson", new DateTime(2023, 7, 27, 12, 33, 10, 900, DateTimeKind.Local).AddTicks(5328), new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5326), null, 3, "Quiffy", 1, 2, 2, 3, null, 3m }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Chipped", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "Name", "Neutered", "OwnerId", "Sex", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 8, 2, "Anna Bergsson", null, new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5332), null, "Woffy", 1, 2, 1, 3, null, 4m });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "CreatedBy", "DateOfBirth", "DateRegistered", "DateUpdated", "Name", "OwnerId", "SpeciesId", "UpdatedBy", "WeightInKilos" },
                values: new object[] { 3, "Anna Bergsson", null, new DateTime(2023, 7, 27, 10, 33, 10, 900, DateTimeKind.Utc).AddTicks(5244), null, "Dundy", 1, 4, null, 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Species",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
