using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class CategoriesPlats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categoriesPlats_Cuisiniers_CuisinierId",
                table: "categoriesPlats");

            migrationBuilder.RenameColumn(
                name: "CuisinierId",
                table: "categoriesPlats",
                newName: "cuisinierId");

            migrationBuilder.RenameIndex(
                name: "IX_categoriesPlats_CuisinierId",
                table: "categoriesPlats",
                newName: "IX_categoriesPlats_cuisinierId");

            migrationBuilder.AddForeignKey(
                name: "FK_categoriesPlats_Cuisiniers_cuisinierId",
                table: "categoriesPlats",
                column: "cuisinierId",
                principalTable: "Cuisiniers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categoriesPlats_Cuisiniers_cuisinierId",
                table: "categoriesPlats");

            migrationBuilder.RenameColumn(
                name: "cuisinierId",
                table: "categoriesPlats",
                newName: "CuisinierId");

            migrationBuilder.RenameIndex(
                name: "IX_categoriesPlats_cuisinierId",
                table: "categoriesPlats",
                newName: "IX_categoriesPlats_CuisinierId");

            migrationBuilder.AddForeignKey(
                name: "FK_categoriesPlats_Cuisiniers_CuisinierId",
                table: "categoriesPlats",
                column: "CuisinierId",
                principalTable: "Cuisiniers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
