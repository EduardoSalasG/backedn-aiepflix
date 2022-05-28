using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backedn_aiepflix.Migrations
{
    public partial class RUT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "RUT",
                columns: table => new
                {
                    Rut = table.Column<string>(type: "nvarchar(max)", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreActividad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoActividad = table.Column<int>(type: "int", nullable: false),
                    AfectoIVA = table.Column<bool>(type: "bit", nullable: false),
                    FechaInicioAct = table.Column<DateTime>(type: "datetime2", nullable: false)
                });
                
        }
    }
}
