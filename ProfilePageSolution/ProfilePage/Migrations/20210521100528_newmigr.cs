using Microsoft.EntityFrameworkCore.Migrations;

namespace ProfilePage.Migrations
{
    public partial class newmigr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployed = table.Column<bool>(type: "bit", nullable: false),
                    NoticePeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentCTC = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "ID", "Age", "CurrentCTC", "IsEmployed", "Name", "NoticePeriod", "Qualification" },
                values: new object[] { 1, 20, 45000f, true, "ramu", "One month", "B.Sc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
