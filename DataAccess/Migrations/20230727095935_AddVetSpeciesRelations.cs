using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddVetSpeciesRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpeciesVet",
                columns: table => new
                {
                    SpecializationsId = table.Column<int>(type: "int", nullable: false),
                    VetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeciesVet", x => new { x.SpecializationsId, x.VetsId });
                    table.ForeignKey(
                        name: "FK_SpeciesVet_Species_SpecializationsId",
                        column: x => x.SpecializationsId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeciesVet_Vets_VetsId",
                        column: x => x.VetsId,
                        principalTable: "Vets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpeciesVet_VetsId",
                table: "SpeciesVet",
                column: "VetsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpeciesVet");
        }
    }
}
