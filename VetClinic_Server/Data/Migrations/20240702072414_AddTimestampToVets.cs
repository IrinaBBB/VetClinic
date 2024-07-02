using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetClinic_Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTimestampToVets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Vets",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Vets");
        }
    }
}
