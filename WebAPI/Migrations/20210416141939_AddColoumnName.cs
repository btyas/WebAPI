using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class AddColoumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageUrl_Cuisiniers_CuisiniersId",
                table: "ImageUrl");

            migrationBuilder.DropIndex(
                name: "IX_ImageUrl_CuisiniersId",
                table: "ImageUrl");

            migrationBuilder.DropColumn(
                name: "CuisiniersId",
                table: "ImageUrl");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePaths",
                table: "ImageUrl",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CuisinierId",
                table: "ImageUrl",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageCuisinierUrl",
                table: "Cuisiniers",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cuisiniers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ImageUrl_CuisinierId",
                table: "ImageUrl",
                column: "CuisinierId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageUrl_Cuisiniers_CuisinierId",
                table: "ImageUrl",
                column: "CuisinierId",
                principalTable: "Cuisiniers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ImageUrl_Cuisiniers_CuisinierId",
                table: "ImageUrl");

            migrationBuilder.DropIndex(
                name: "IX_ImageUrl_CuisinierId",
                table: "ImageUrl");

            migrationBuilder.DropColumn(
                name: "CuisinierId",
                table: "ImageUrl");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cuisiniers");

            migrationBuilder.AlterColumn<string>(
                name: "ImagePaths",
                table: "ImageUrl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CuisiniersId",
                table: "ImageUrl",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageCuisinierUrl",
                table: "Cuisiniers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ImageUrl_CuisiniersId",
                table: "ImageUrl",
                column: "CuisiniersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ImageUrl_Cuisiniers_CuisiniersId",
                table: "ImageUrl",
                column: "CuisiniersId",
                principalTable: "Cuisiniers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
