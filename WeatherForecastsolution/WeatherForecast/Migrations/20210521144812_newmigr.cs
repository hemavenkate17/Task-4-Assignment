using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherForecast.Migrations
{
    public partial class newmigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "weathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    highTemp = table.Column<int>(type: "int", nullable: false),
                    lowTemp = table.Column<int>(type: "int", nullable: false),
                    Forecast = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weathers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "weathers");
        }
    }
}
