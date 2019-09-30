using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonsterApp.Migrations
{
    public partial class seeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "MonsterId", "Attack", "Defense", "Health", "Level", "MonsterTypeId", "Name" },
                values: new object[,]
                {
                    { 1, 0, 0, 5, 1, null, "Bulbasaur" },
                    { 2, 0, 0, 5, 1, null, "Pichu" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "DateAccountCreated", "EmailAddress", "FirstName", "Gold", "LastName", "Password", "UserTypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 18, 21, 22, 39, 217, DateTimeKind.Local), "ambremandar@gmail.com", "Mandar", 1, "Ambre", "test123", 1 },
                    { 2, new DateTime(2019, 8, 18, 21, 22, 39, 218, DateTimeKind.Local), "steve.rossiter@ancoraeducation.com", "Steve", 1, "Rossiter", "test123", 1 },
                    { 3, new DateTime(2019, 8, 18, 21, 22, 39, 218, DateTimeKind.Local), "admin@asp.net", "Super", 1, "Admin", "test123", 1 }

                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);
        }
    }
}
