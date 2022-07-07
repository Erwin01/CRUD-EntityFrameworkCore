using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUDEntityFramework.Migrations
{
    public partial class AddObjectPoblationPaisAndTablePresidente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Poblation",
                table: "Paises",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Presidentes",
                columns: table => new
                {
                    Cedula = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presidentes", x => x.Cedula);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presidentes");

            migrationBuilder.DropColumn(
                name: "Poblation",
                table: "Paises");

           
        }
    }
}
