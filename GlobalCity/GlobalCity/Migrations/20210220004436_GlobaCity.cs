using Microsoft.EntityFrameworkCore.Migrations;

namespace GlobalCity.Migrations
{
    public partial class GlobaCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    Code = table.Column<string>(type: "char(3)", nullable: false),
                    Name = table.Column<string>(type: "char(52)", nullable: false),
                    Region = table.Column<string>(type: "char(26)", nullable: false),
                    NationalFlag = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "char(35)", nullable: false),
                    CountryCode = table.Column<string>(type: "char(3)", nullable: false),
                    District = table.Column<string>(type: "char(20)", nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.ID);
                    table.ForeignKey(
                        name: "FK_city_country_CountryCode",
                        column: x => x.CountryCode,
                        principalTable: "country",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "CountryCode",
                table: "city",
                column: "CountryCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
