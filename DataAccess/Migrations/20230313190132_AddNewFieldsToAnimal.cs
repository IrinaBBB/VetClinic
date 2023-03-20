using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddNewFieldsToAnimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Neutered",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Chipped",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 2,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<bool>(
                name: "DateOfBirthIsKnown",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirthIsKnown",
                table: "Animals");

            migrationBuilder.AlterColumn<bool>(
                name: "Neutered",
                table: "Animals",
                type: "bit",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2);

            migrationBuilder.AlterColumn<bool>(
                name: "Chipped",
                table: "Animals",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2);
        }
    }
}
