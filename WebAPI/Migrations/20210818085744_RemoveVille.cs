using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class RemoveVille : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoriesPlats_Cuisiniers_CuisinierId",
                table: "CategoriesPlats");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Villes_VilleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Villes");

            migrationBuilder.DropIndex(
                name: "IX_Users_VilleId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriesPlats",
                table: "CategoriesPlats");

            migrationBuilder.DropColumn(
                name: "VilleId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "CategoriesPlats",
                newName: "categoriesPlats");

            migrationBuilder.RenameIndex(
                name: "IX_CategoriesPlats_CuisinierId",
                table: "categoriesPlats",
                newName: "IX_categoriesPlats_CuisinierId");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoriesPlats",
                table: "categoriesPlats",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_categoriesPlats_Cuisiniers_CuisinierId",
                table: "categoriesPlats",
                column: "CuisinierId",
                principalTable: "Cuisiniers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categoriesPlats_Cuisiniers_CuisinierId",
                table: "categoriesPlats");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CityId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoriesPlats",
                table: "categoriesPlats");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "categoriesPlats",
                newName: "CategoriesPlats");

            migrationBuilder.RenameIndex(
                name: "IX_categoriesPlats_CuisinierId",
                table: "CategoriesPlats",
                newName: "IX_CategoriesPlats_CuisinierId");

            migrationBuilder.AddColumn<int>(
                name: "VilleId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriesPlats",
                table: "CategoriesPlats",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Villes",
                columns: table => new
                {
                    VilleId = table.Column<int>(type: "int", nullable: false),
                    CodePostal = table.Column<int>(type: "int", nullable: false),
                    IdDepartment = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    NomVille = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villes", x => x.VilleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_VilleId",
                table: "Users",
                column: "VilleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoriesPlats_Cuisiniers_CuisinierId",
                table: "CategoriesPlats",
                column: "CuisinierId",
                principalTable: "Cuisiniers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Villes_VilleId",
                table: "Users",
                column: "VilleId",
                principalTable: "Villes",
                principalColumn: "VilleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
