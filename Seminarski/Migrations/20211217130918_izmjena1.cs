using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarski.Migrations
{
    public partial class izmjena1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "ProizvodiStavka",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "ProizvodiStavka");
        }
    }
}
