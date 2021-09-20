using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCoreApp.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TanimliKullanici",
                table: "UsersInfo",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "TanimliKullaniciSifre",
                table: "UsersInfo",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanimliKullanici",
                table: "UsersInfo");

            migrationBuilder.DropColumn(
                name: "TanimliKullaniciSifre",
                table: "UsersInfo");
        }
    }
}
