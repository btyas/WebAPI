using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class Initial10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CodePostale = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CodePostale);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Gender = table.Column<int>(nullable: false),
                    CodePostalUser = table.Column<int>(nullable: false),
                    CityCodePostale = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityCodePostale",
                        column: x => x.CityCodePostale,
                        principalTable: "Cities",
                        principalColumn: "CodePostale",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityCodePostale",
                table: "Users",
                column: "CityCodePostale");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
