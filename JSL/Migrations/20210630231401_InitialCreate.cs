using Microsoft.EntityFrameworkCore.Migrations;

namespace JSL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeMotorista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    enderecoMotorista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cidadeMotorista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estadoMotorista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    marcaCaminhao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    modeloCaminhao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    placaCaminhao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qntEixos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motoristas");
        }
    }
}
