using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarski.Migrations
{
    public partial class izmjena2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "ProizvodiStavka");

            migrationBuilder.DropColumn(
                name: "SkladisteId",
                table: "ProizvodiStavka");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "ProizvodiStavka",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkladisteId",
                table: "ProizvodiStavka",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
