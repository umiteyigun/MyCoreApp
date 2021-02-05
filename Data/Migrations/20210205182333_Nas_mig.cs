using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCoreApp.Data.Migrations
{
    public partial class Nas_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nasname = table.Column<string>(nullable: true),
                    Shortname = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Ports = table.Column<int>(nullable: true),
                    Secret = table.Column<string>(nullable: true),
                    Server = table.Column<string>(nullable: true),
                    Community = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nas");
        }
    }
}
