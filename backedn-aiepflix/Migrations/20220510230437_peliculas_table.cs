using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backedn_aiepflix.Migrations
{
    public partial class peliculas_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fcea67-43eb-4ece-8e5a-c0f32c3bbff5",
                column: "ConcurrencyStamp",
                value: "383f3e75-efcb-4b61-948e-f6007434f105");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fcea67-43eb-4ece-8e5a-c0f32c3bbff5",
                column: "ConcurrencyStamp",
                value: "6a56db14-6e37-49cd-bbbb-6fa2a30dfe6c");
        }
    }
}
