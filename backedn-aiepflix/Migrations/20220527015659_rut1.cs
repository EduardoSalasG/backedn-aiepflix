using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backedn_aiepflix.Migrations
{
    public partial class rut1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                 name: "RUT",
                 columns: table => new
                 {
                     Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                     Rut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                     Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                     NombreActividad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                     CodigoActividad = table.Column<int>(type: "int", nullable: false),
                     AfectoIVA = table.Column<bool>(type: "bit", nullable: false),
                     FechaInicioAct = table.Column<DateTime>(type: "datetime2", nullable: false)
                 },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RUT", x => x.Id);
                });


        }
    }
}
