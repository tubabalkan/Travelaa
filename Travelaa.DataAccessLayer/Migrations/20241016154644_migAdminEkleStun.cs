using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Travelaa.DataAccessLayer.Migrations
{
    public partial class migAdminEkleStun : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Admins");
        }
    }
}
