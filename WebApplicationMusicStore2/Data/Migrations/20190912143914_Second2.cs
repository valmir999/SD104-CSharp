using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMusicStore2.Data.Migrations
{
    public partial class Second2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Song",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Song",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Song");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Song");
        }
    }
}
