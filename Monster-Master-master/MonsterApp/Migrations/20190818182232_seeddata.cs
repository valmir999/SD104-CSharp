using Microsoft.EntityFrameworkCore.Migrations;

namespace MonsterApp.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MonsterTypes",
                columns: new[] { "MonsterTypeId", "Description", "TypeName" },
                values: new object[,]
                {
                    { 1, null, "Generation I" },
                    { 2, null, "Generation II" },
                    { 3, null, "Generation III" },
                    { 4, null, "Generation IV" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "UserTypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MonsterTypes",
                keyColumn: "MonsterTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MonsterTypes",
                keyColumn: "MonsterTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MonsterTypes",
                keyColumn: "MonsterTypeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MonsterTypes",
                keyColumn: "MonsterTypeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "UserTypeId",
                keyValue: 2);
        }
    }
}
