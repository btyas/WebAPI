using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cuisiniers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageCuisinierUrl = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuisiniers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuisiniers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageUrl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePaths = table.Column<string>(nullable: true),
                    CuisiniersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUrl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUrl_Cuisiniers_CuisiniersId",
                        column: x => x.CuisiniersId,
                        principalTable: "Cuisiniers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuisiniers_CityId",
                table: "Cuisiniers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageUrl_CuisiniersId",
                table: "ImageUrl",
                column: "CuisiniersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageUrl");

            migrationBuilder.DropTable(
                name: "Cuisiniers");
        }
    }
}
