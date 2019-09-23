using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMusicStore2.Data.Migrations
{
    public partial class Cust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Customer");
        }
    }
}
