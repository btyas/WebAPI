using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class Proj170622 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdressPostal",
                table: "Streets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Streets",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PosLatitude",
                table: "Stations",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PosLongitude",
                table: "Stations",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "StreetName",
                table: "Stations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressPostal",
                table: "Streets");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Streets");

            migrationBuilder.DropColumn(
                name: "PosLatitude",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "PosLongitude",
                table: "Stations");

            migrationBuilder.DropColumn(
                name: "StreetName",
                table: "Stations");
        }
    }
}
