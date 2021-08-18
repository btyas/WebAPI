using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class NewMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesPlatsId",
                table: "plats",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_plats_CategoriesPlatsId",
                table: "plats",
                column: "CategoriesPlatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_plats_categoriesPlats_CategoriesPlatsId",
                table: "plats",
                column: "CategoriesPlatsId",
                principalTable: "categoriesPlats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_plats_categoriesPlats_CategoriesPlatsId",
                table: "plats");

            migrationBuilder.DropIndex(
                name: "IX_plats_CategoriesPlatsId",
                table: "plats");

            migrationBuilder.DropColumn(
                name: "CategoriesPlatsId",
                table: "plats");
        }
    }
}
