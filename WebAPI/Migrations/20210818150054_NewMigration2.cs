using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class NewMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "listeDesPlats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePlats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listeDesPlats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "plats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ListeDesPlatsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_plats_listeDesPlats_ListeDesPlatsId",
                        column: x => x.ListeDesPlatsId,
                        principalTable: "listeDesPlats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "imagePlats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageplatName = table.Column<string>(nullable: true),
                    PlatId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_imagePlats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_imagePlats_plats_PlatId",
                        column: x => x.PlatId,
                        principalTable: "plats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_imagePlats_PlatId",
                table: "imagePlats",
                column: "PlatId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_plats_ListeDesPlatsId",
                table: "plats",
                column: "ListeDesPlatsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "imagePlats");

            migrationBuilder.DropTable(
                name: "plats");

            migrationBuilder.DropTable(
                name: "listeDesPlats");
        }
    }
}
