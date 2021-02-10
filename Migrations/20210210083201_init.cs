using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCoreApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccessPoints",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Nasname = table.Column<string>(nullable: true),
                    Ip = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Secret = table.Column<string>(nullable: true),
                    Port = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    Long = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccessPoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bakiye",
                columns: table => new
                {
                    Bakiyeid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Gelir = table.Column<string>(nullable: true),
                    Gider = table.Column<string>(nullable: true),
                    Tarih = table.Column<string>(nullable: true),
                    Ekleyen = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    Baglanti = table.Column<string>(nullable: true),
                    Baglantitip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bakiye", x => x.Bakiyeid);
                });

            migrationBuilder.CreateTable(
                name: "Basvuru",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Badi = table.Column<string>(nullable: true),
                    Bsoyadi = table.Column<string>(nullable: true),
                    Btc = table.Column<string>(nullable: true),
                    Bemail = table.Column<string>(nullable: true),
                    Badresi = table.Column<string>(nullable: true),
                    Btelefon1 = table.Column<string>(nullable: true),
                    Btelefon2 = table.Column<string>(nullable: true),
                    Btelefon3 = table.Column<string>(nullable: true),
                    Bpaket = table.Column<string>(nullable: true),
                    Bftipi = table.Column<string>(nullable: true),
                    Bil = table.Column<string>(nullable: true),
                    Bilce = table.Column<string>(nullable: true),
                    Brandevu = table.Column<string>(nullable: true),
                    Bsms = table.Column<string>(nullable: true),
                    Bsmsid = table.Column<string>(nullable: true),
                    Bbildiren = table.Column<string>(nullable: true),
                    Bsonuc = table.Column<string>(nullable: true),
                    Baciklama = table.Column<string>(nullable: true),
                    Bhakedis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basvuru", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BtkNat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KullaniciAd = table.Column<string>(nullable: true),
                    OzelIp = table.Column<string>(nullable: true),
                    OIpPBas = table.Column<string>(nullable: true),
                    OIpPBit = table.Column<string>(nullable: true),
                    GercekIp = table.Column<string>(nullable: true),
                    GIpPBas = table.Column<string>(nullable: true),
                    GIpPBit = table.Column<string>(nullable: true),
                    OBasTarih = table.Column<string>(nullable: true),
                    OBitTarih = table.Column<string>(nullable: true),
                    UpByte = table.Column<string>(nullable: true),
                    DownByte = table.Column<string>(nullable: true),
                    BKM = table.Column<string>(nullable: true),
                    ODurum = table.Column<string>(nullable: true),
                    BPvc = table.Column<string>(nullable: true),
                    ServisNo = table.Column<string>(nullable: true),
                    OKod = table.Column<string>(nullable: true),
                    Imza = table.Column<sbyte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtkNat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Tc = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Mode = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetroIp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nasname = table.Column<string>(nullable: true),
                    Ipaddress = table.Column<string>(nullable: true),
                    Ports = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetroIp", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "PacketsInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Download = table.Column<string>(nullable: true),
                    Upload = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Traffic = table.Column<string>(nullable: true),
                    Sat = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacketsInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radacct",
                columns: table => new
                {
                    Radacctid = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Acctsessionid = table.Column<string>(nullable: true),
                    Acctuniqueid = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Groupname = table.Column<string>(nullable: true),
                    Realm = table.Column<string>(nullable: true),
                    Nasipaddress = table.Column<string>(nullable: true),
                    Nasportid = table.Column<string>(nullable: true),
                    Nasporttype = table.Column<string>(nullable: true),
                    Acctstarttime = table.Column<DateTime>(nullable: true),
                    Acctstoptime = table.Column<DateTime>(nullable: true),
                    Acctsessiontime = table.Column<uint>(nullable: true),
                    Acctauthentic = table.Column<string>(nullable: true),
                    ConnectinfoStart = table.Column<string>(nullable: true),
                    ConnectinfoStop = table.Column<string>(nullable: true),
                    Acctinputoctets = table.Column<long>(nullable: true),
                    Acctoutputoctets = table.Column<long>(nullable: true),
                    Calledstationid = table.Column<string>(nullable: true),
                    Callingstationid = table.Column<string>(nullable: true),
                    Acctterminatecause = table.Column<string>(nullable: true),
                    Servicetype = table.Column<string>(nullable: true),
                    Framedprotocol = table.Column<string>(nullable: true),
                    Framedipaddress = table.Column<string>(nullable: true),
                    Acctstartdelay = table.Column<uint>(nullable: true),
                    Acctstopdelay = table.Column<uint>(nullable: true),
                    Xascendsessionsvrkey = table.Column<string>(nullable: true),
                    Btk = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radacct", x => x.Radacctid);
                });

            migrationBuilder.CreateTable(
                name: "Radcheck",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Attribute = table.Column<string>(nullable: true),
                    Op = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Regdate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radcheck", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radgroupcheck",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Groupname = table.Column<string>(nullable: true),
                    Attribute = table.Column<string>(nullable: true),
                    Op = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radgroupcheck", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radgroupreply",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Groupname = table.Column<string>(nullable: true),
                    Attribute = table.Column<string>(nullable: true),
                    Op = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radgroupreply", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radippool",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PoolName = table.Column<string>(nullable: true),
                    Framedipaddress = table.Column<string>(nullable: true),
                    Nasipaddress = table.Column<string>(nullable: true),
                    Calledstationid = table.Column<string>(nullable: true),
                    Callingstationid = table.Column<string>(nullable: true),
                    ExpiryTime = table.Column<DateTime>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PoolKey = table.Column<string>(nullable: true),
                    Port = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radippool", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radpostauth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    Reply = table.Column<string>(nullable: true),
                    Authdate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radpostauth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radreply",
                columns: table => new
                {
                    Id = table.Column<uint>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Attribute = table.Column<string>(nullable: true),
                    Op = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radreply", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Radusergroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Groupname = table.Column<string>(nullable: true),
                    Priority = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radusergroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sayi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NatSayi = table.Column<int>(nullable: true),
                    KutukSayi = table.Column<int>(nullable: true),
                    Tarih = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sayi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Sms1 = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Smsbilgi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Smsuser = table.Column<string>(nullable: true),
                    Smspass = table.Column<string>(nullable: true),
                    Smsno = table.Column<string>(nullable: true),
                    Smsapi = table.Column<string>(nullable: true),
                    Dis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smsbilgi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInvoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: true),
                    Peydate = table.Column<DateTime>(nullable: true),
                    Expire = table.Column<DateTime>(nullable: true),
                    Packet = table.Column<string>(nullable: true),
                    Tdurum = table.Column<string>(nullable: true),
                    Taciklama = table.Column<string>(nullable: true),
                    Tyapan = table.Column<string>(nullable: true),
                    Kaciklama = table.Column<string>(nullable: true),
                    Kmesaj = table.Column<string>(nullable: true),
                    Taksit = table.Column<string>(nullable: true),
                    Tekrar = table.Column<int>(nullable: true),
                    Otarihi = table.Column<DateTime>(nullable: true),
                    Sms = table.Column<string>(nullable: true),
                    Mcoid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInvoices", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccessPoints");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bakiye");

            migrationBuilder.DropTable(
                name: "Basvuru");

            migrationBuilder.DropTable(
                name: "BtkNat");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "MetroIp");

            migrationBuilder.DropTable(
                name: "Nas");

            migrationBuilder.DropTable(
                name: "PacketsInfo");

            migrationBuilder.DropTable(
                name: "Radacct");

            migrationBuilder.DropTable(
                name: "Radcheck");

            migrationBuilder.DropTable(
                name: "Radgroupcheck");

            migrationBuilder.DropTable(
                name: "Radgroupreply");

            migrationBuilder.DropTable(
                name: "Radippool");

            migrationBuilder.DropTable(
                name: "Radpostauth");

            migrationBuilder.DropTable(
                name: "Radreply");

            migrationBuilder.DropTable(
                name: "Radusergroup");

            migrationBuilder.DropTable(
                name: "Sayi");

            migrationBuilder.DropTable(
                name: "Sms");

            migrationBuilder.DropTable(
                name: "Smsbilgi");

            migrationBuilder.DropTable(
                name: "UserInvoices");

            migrationBuilder.DropTable(
                name: "UsersInfo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
