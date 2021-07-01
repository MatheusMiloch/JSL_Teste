using Microsoft.EntityFrameworkCore.Migrations;

namespace JSL.Migrations
{
    public partial class TabelaViagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataViagem = table.Column<int>(type: "int", nullable: false),
                    LocalEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalSaida = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KmTotal = table.Column<int>(type: "int", nullable: false),
                    motoristaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Viagens_Motoristas_motoristaId",
                        column: x => x.motoristaId,
                        principalTable: "Motoristas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viagens_motoristaId",
                table: "Viagens",
                column: "motoristaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagens");
        }
    }
}
