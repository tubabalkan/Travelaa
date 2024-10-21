using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travelaa.DataAccessLayer.Migrations
{
    public partial class mig_galeri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galeris",
                columns: table => new
                {
                    GaleriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GaleriUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeris", x => x.GaleriId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galeris");
        }
    }
}
