using Microsoft.EntityFrameworkCore.Migrations;

namespace Seminarski.Migrations
{
    public partial class KorisnickiNalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KorisnickiNalogId",
                table: "Uposlenici",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "KorisnickiNalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalog", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uposlenici_KorisnickiNalogId",
                table: "Uposlenici",
                column: "KorisnickiNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Uposlenici_KorisnickiNalog_KorisnickiNalogId",
                table: "Uposlenici",
                column: "KorisnickiNalogId",
                principalTable: "KorisnickiNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Uposlenici_KorisnickiNalog_KorisnickiNalogId",
                table: "Uposlenici");

            migrationBuilder.DropTable(
                name: "KorisnickiNalog");

            migrationBuilder.DropIndex(
                name: "IX_Uposlenici_KorisnickiNalogId",
                table: "Uposlenici");

            migrationBuilder.DropColumn(
                name: "KorisnickiNalogId",
                table: "Uposlenici");
        }
    }
}
