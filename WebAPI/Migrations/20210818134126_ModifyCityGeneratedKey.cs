using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class ModifyCityGeneratedKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuisiniers_Cities_CityId",
                table: "Cuisiniers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CityId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityCodePostale",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodePostale",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "CodePostale");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityCodePostale",
                table: "Users",
                column: "CityCodePostale");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuisiniers_Cities_CityId",
                table: "Cuisiniers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CodePostale",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_CityCodePostale",
                table: "Users",
                column: "CityCodePostale",
                principalTable: "Cities",
                principalColumn: "CodePostale",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuisiniers_Cities_CityId",
                table: "Cuisiniers");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_CityCodePostale",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CityCodePostale",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityCodePostale",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CodePostale",
                table: "Cities");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuisiniers_Cities_CityId",
                table: "Cuisiniers",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_CityId",
                table: "Users",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
