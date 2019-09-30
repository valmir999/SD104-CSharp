using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonsterApp.Migrations
{
    public partial class initialmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserMonsterCollections",
                columns: table => new
                {
                    UserMonsterCollectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true),
                    MonsterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMonsterCollections", x => x.UserMonsterCollectionId);
                    table.ForeignKey(
                        name: "FK_UserMonsterCollections_Monsters_MonsterId",
                        column: x => x.MonsterId,
                        principalTable: "Monsters",
                        principalColumn: "MonsterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserMonsterCollections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAccountCreated",
                value: new DateTime(2019, 8, 18, 21, 46, 56, 78, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAccountCreated",
                value: new DateTime(2019, 8, 18, 21, 46, 56, 80, DateTimeKind.Local));

            migrationBuilder.CreateIndex(
                name: "IX_UserMonsterCollections_MonsterId",
                table: "UserMonsterCollections",
                column: "MonsterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMonsterCollections_UserId",
                table: "UserMonsterCollections",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMonsterCollections");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAccountCreated",
                value: new DateTime(2019, 8, 18, 21, 42, 13, 426, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAccountCreated",
                value: new DateTime(2019, 8, 18, 21, 42, 13, 427, DateTimeKind.Local));
        }
    }
}
