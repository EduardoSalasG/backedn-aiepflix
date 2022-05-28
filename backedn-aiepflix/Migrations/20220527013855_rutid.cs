using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backedn_aiepflix.Migrations
{
    public partial class rutid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "RUT",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fcea67-43eb-4ece-8e5a-c0f32c3bbff5",
                column: "ConcurrencyStamp",
                value: "2a9c96b7-c8e9-4ee4-b02a-3ea18e84938e");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "RUT");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91fcea67-43eb-4ece-8e5a-c0f32c3bbff5",
                column: "ConcurrencyStamp",
                value: "57e53df8-a9e8-4c30-b7eb-6a279bc78878");
        }
    }
}
