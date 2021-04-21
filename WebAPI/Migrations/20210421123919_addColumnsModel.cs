using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class addColumnsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Cuisiniers",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Cuisiniers",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ZIPCode",
                table: "Cuisiniers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Cuisiniers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Cuisiniers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Cuisiniers");

            migrationBuilder.DropColumn(
                name: "ZIPCode",
                table: "Cuisiniers");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Cuisiniers");
        }
    }
}
