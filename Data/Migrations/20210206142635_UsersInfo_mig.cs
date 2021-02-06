using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCoreApp.Data.Migrations
{
    public partial class UsersInfo_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Tc = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Phone3 = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Packet = table.Column<string>(nullable: true),
                    Accesspoint = table.Column<string>(nullable: true),
                    Ftipi = table.Column<string>(nullable: true),
                    Osifre = table.Column<string>(nullable: true),
                    Adurum = table.Column<string>(nullable: true),
                    Sabitip = table.Column<string>(nullable: true),
                    Atipi = table.Column<string>(nullable: true),
                    Pasaportno = table.Column<int>(nullable: true),
                    Unvan = table.Column<string>(nullable: true),
                    Vergino = table.Column<int>(nullable: true),
                    Cinsiyet = table.Column<string>(nullable: true),
                    Uyruk = table.Column<string>(nullable: true),
                    Babaadi = table.Column<string>(nullable: true),
                    Anaadi = table.Column<string>(nullable: true),
                    Anakizliksoyadi = table.Column<string>(nullable: true),
                    Dogumyeri = table.Column<string>(nullable: true),
                    Dogumtarihi = table.Column<string>(nullable: true),
                    Meslek = table.Column<string>(nullable: true),
                    Ciltno = table.Column<int>(nullable: true),
                    Kutukno = table.Column<int>(nullable: true),
                    Sayfano = table.Column<int>(nullable: true),
                    Kil = table.Column<string>(nullable: true),
                    Kilce = table.Column<string>(nullable: true),
                    Mahkoy = table.Column<string>(nullable: true),
                    Ktipi = table.Column<string>(nullable: true),
                    Kserino = table.Column<string>(nullable: true),
                    Kverildigiyer = table.Column<string>(nullable: true),
                    Kverildigitarih = table.Column<string>(nullable: true),
                    Ksahibi = table.Column<string>(nullable: true),
                    Til = table.Column<string>(nullable: true),
                    Tilce = table.Column<string>(nullable: true),
                    Tmahalle = table.Column<string>(nullable: true),
                    Tcadde = table.Column<string>(nullable: true),
                    Tdiskapino = table.Column<string>(nullable: true),
                    Tickapino = table.Column<string>(nullable: true),
                    Tpostano = table.Column<int>(nullable: true),
                    Tadresno = table.Column<int>(nullable: true),
                    Vergidairesi = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersInfo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersInfo");
        }
    }
}
