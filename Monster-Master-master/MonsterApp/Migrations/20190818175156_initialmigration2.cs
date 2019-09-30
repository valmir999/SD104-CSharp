using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonsterApp.Migrations
{
    public partial class initialmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonsterTypes",
                columns: table => new
                {
                    MonsterTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterTypes", x => x.MonsterTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    MonsterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    MonsterTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.MonsterId);
                    table.ForeignKey(
                        name: "FK_Monsters_MonsterTypes_MonsterTypeId",
                        column: x => x.MonsterTypeId,
                        principalTable: "MonsterTypes",
                        principalColumn: "MonsterTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_MonsterTypeId",
                table: "Monsters",
                column: "MonsterTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "MonsterTypes");
        }
    }
}
