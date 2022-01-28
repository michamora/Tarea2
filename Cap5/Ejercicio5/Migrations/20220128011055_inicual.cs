using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ejercicio4.Migrations
{
    public partial class inicual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factorial",
                columns: table => new
                {
                    Numeroid = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factorial", x => x.Numeroid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factorial");
        }
    }
}
