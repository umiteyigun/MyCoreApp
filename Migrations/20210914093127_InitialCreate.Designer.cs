﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCoreApp.Data;

namespace MyCoreApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210914093127_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("MyCoreApp.Models.AccessPoints", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Ip")
                        .HasColumnType("longtext");

                    b.Property<string>("Lat")
                        .HasColumnType("longtext");

                    b.Property<string>("Long")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Nasname")
                        .HasColumnType("longtext");

                    b.Property<int?>("Port")
                        .HasColumnType("int");

                    b.Property<string>("Secret")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AccessPoints");
                });

            modelBuilder.Entity("MyCoreApp.Models.Bakiye", b =>
                {
                    b.Property<int>("Bakiyeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Aciklama")
                        .HasColumnType("longtext");

                    b.Property<string>("Baglanti")
                        .HasColumnType("longtext");

                    b.Property<string>("Baglantitip")
                        .HasColumnType("longtext");

                    b.Property<string>("Ekleyen")
                        .HasColumnType("longtext");

                    b.Property<string>("Gelir")
                        .HasColumnType("longtext");

                    b.Property<string>("Gider")
                        .HasColumnType("longtext");

                    b.Property<string>("Tarih")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Bakiyeid");

                    b.ToTable("Bakiye");
                });

            modelBuilder.Entity("MyCoreApp.Models.Basvuru", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Baciklama")
                        .HasColumnType("longtext");

                    b.Property<string>("Badi")
                        .HasColumnType("longtext");

                    b.Property<string>("Badresi")
                        .HasColumnType("longtext");

                    b.Property<string>("Bbildiren")
                        .HasColumnType("longtext");

                    b.Property<string>("Bemail")
                        .HasColumnType("longtext");

                    b.Property<string>("Bftipi")
                        .HasColumnType("longtext");

                    b.Property<string>("Bhakedis")
                        .HasColumnType("longtext");

                    b.Property<string>("Bil")
                        .HasColumnType("longtext");

                    b.Property<string>("Bilce")
                        .HasColumnType("longtext");

                    b.Property<string>("Bpaket")
                        .HasColumnType("longtext");

                    b.Property<string>("Brandevu")
                        .HasColumnType("longtext");

                    b.Property<string>("Bsms")
                        .HasColumnType("longtext");

                    b.Property<string>("Bsmsid")
                        .HasColumnType("longtext");

                    b.Property<string>("Bsonuc")
                        .HasColumnType("longtext");

                    b.Property<string>("Bsoyadi")
                        .HasColumnType("longtext");

                    b.Property<string>("Btc")
                        .HasColumnType("longtext");

                    b.Property<string>("Btelefon1")
                        .HasColumnType("longtext");

                    b.Property<string>("Btelefon2")
                        .HasColumnType("longtext");

                    b.Property<string>("Btelefon3")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Basvuru");
                });

            modelBuilder.Entity("MyCoreApp.Models.BtkNat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BKM")
                        .HasColumnType("longtext");

                    b.Property<string>("BPvc")
                        .HasColumnType("longtext");

                    b.Property<string>("DownByte")
                        .HasColumnType("longtext");

                    b.Property<string>("GIpPBas")
                        .HasColumnType("longtext");

                    b.Property<string>("GIpPBit")
                        .HasColumnType("longtext");

                    b.Property<string>("GercekIp")
                        .HasColumnType("longtext");

                    b.Property<sbyte?>("Imza")
                        .HasColumnType("tinyint");

                    b.Property<string>("KullaniciAd")
                        .HasColumnType("longtext");

                    b.Property<string>("OBasTarih")
                        .HasColumnType("longtext");

                    b.Property<string>("OBitTarih")
                        .HasColumnType("longtext");

                    b.Property<string>("ODurum")
                        .HasColumnType("longtext");

                    b.Property<string>("OIpPBas")
                        .HasColumnType("longtext");

                    b.Property<string>("OIpPBit")
                        .HasColumnType("longtext");

                    b.Property<string>("OKod")
                        .HasColumnType("longtext");

                    b.Property<string>("OzelIp")
                        .HasColumnType("longtext");

                    b.Property<string>("ServisNo")
                        .HasColumnType("longtext");

                    b.Property<string>("UpByte")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("BtkNat");
                });

            modelBuilder.Entity("MyCoreApp.Models.Members", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Lastname")
                        .HasColumnType("longtext");

                    b.Property<string>("Mode")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext");

                    b.Property<string>("Photo")
                        .HasColumnType("longtext");

                    b.Property<string>("Tc")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("MyCoreApp.Models.MetroIp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Ipaddress")
                        .HasColumnType("longtext");

                    b.Property<string>("Nasname")
                        .HasColumnType("longtext");

                    b.Property<string>("Ports")
                        .HasColumnType("longtext");

                    b.Property<string>("User")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MetroIp");
                });

            modelBuilder.Entity("MyCoreApp.Models.Nas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Community")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Nasname")
                        .HasColumnType("longtext");

                    b.Property<int?>("Ports")
                        .HasColumnType("int");

                    b.Property<string>("Secret")
                        .HasColumnType("longtext");

                    b.Property<string>("Server")
                        .HasColumnType("longtext");

                    b.Property<string>("Shortname")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Nas");
                });

            modelBuilder.Entity("MyCoreApp.Models.PacketsInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Download")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Sat")
                        .HasColumnType("longtext");

                    b.Property<string>("Traffic")
                        .HasColumnType("longtext");

                    b.Property<string>("Upload")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("PacketsInfo");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radacct", b =>
                {
                    b.Property<long>("Radacctid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Acctauthentic")
                        .HasColumnType("longtext");

                    b.Property<long?>("Acctinputoctets")
                        .HasColumnType("bigint");

                    b.Property<long?>("Acctoutputoctets")
                        .HasColumnType("bigint");

                    b.Property<string>("Acctsessionid")
                        .HasColumnType("longtext");

                    b.Property<uint?>("Acctsessiontime")
                        .HasColumnType("int unsigned");

                    b.Property<uint?>("Acctstartdelay")
                        .HasColumnType("int unsigned");

                    b.Property<DateTime?>("Acctstarttime")
                        .HasColumnType("datetime(6)");

                    b.Property<uint?>("Acctstopdelay")
                        .HasColumnType("int unsigned");

                    b.Property<DateTime?>("Acctstoptime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Acctterminatecause")
                        .HasColumnType("longtext");

                    b.Property<string>("Acctuniqueid")
                        .HasColumnType("longtext");

                    b.Property<string>("Btk")
                        .HasColumnType("longtext");

                    b.Property<string>("Calledstationid")
                        .HasColumnType("longtext");

                    b.Property<string>("Callingstationid")
                        .HasColumnType("longtext");

                    b.Property<string>("ConnectinfoStart")
                        .HasColumnType("longtext");

                    b.Property<string>("ConnectinfoStop")
                        .HasColumnType("longtext");

                    b.Property<string>("Framedipaddress")
                        .HasColumnType("longtext");

                    b.Property<string>("Framedprotocol")
                        .HasColumnType("longtext");

                    b.Property<string>("Groupname")
                        .HasColumnType("longtext");

                    b.Property<string>("Nasipaddress")
                        .HasColumnType("longtext");

                    b.Property<string>("Nasportid")
                        .HasColumnType("longtext");

                    b.Property<string>("Nasporttype")
                        .HasColumnType("longtext");

                    b.Property<string>("Realm")
                        .HasColumnType("longtext");

                    b.Property<string>("Servicetype")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("Xascendsessionsvrkey")
                        .HasColumnType("longtext");

                    b.HasKey("Radacctid");

                    b.ToTable("Radacct");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radcheck", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Attribute")
                        .HasColumnType("longtext");

                    b.Property<string>("Op")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Regdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Radcheck");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radgroupcheck", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Attribute")
                        .HasColumnType("longtext");

                    b.Property<string>("Groupname")
                        .HasColumnType("longtext");

                    b.Property<string>("Op")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Radgroupcheck");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radgroupreply", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Attribute")
                        .HasColumnType("longtext");

                    b.Property<string>("Groupname")
                        .HasColumnType("longtext");

                    b.Property<string>("Op")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Radgroupreply");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radippool", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Calledstationid")
                        .HasColumnType("longtext");

                    b.Property<string>("Callingstationid")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ExpiryTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Framedipaddress")
                        .HasColumnType("longtext");

                    b.Property<string>("Nasipaddress")
                        .HasColumnType("longtext");

                    b.Property<string>("PoolKey")
                        .HasColumnType("longtext");

                    b.Property<string>("PoolName")
                        .HasColumnType("longtext");

                    b.Property<string>("Port")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Radippool");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radpostauth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Authdate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Pass")
                        .HasColumnType("longtext");

                    b.Property<string>("Reply")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Radpostauth");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radreply", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Attribute")
                        .HasColumnType("longtext");

                    b.Property<string>("Op")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Radreply");
                });

            modelBuilder.Entity("MyCoreApp.Models.Radusergroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Groupname")
                        .HasColumnType("longtext");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Radusergroup");
                });

            modelBuilder.Entity("MyCoreApp.Models.Sayi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("KutukSayi")
                        .HasColumnType("int");

                    b.Property<int?>("NatSayi")
                        .HasColumnType("int");

                    b.Property<string>("Tarih")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sayi");
                });

            modelBuilder.Entity("MyCoreApp.Models.Sms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.Property<string>("Sms1")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Sms");
                });

            modelBuilder.Entity("MyCoreApp.Models.Smsbilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dis")
                        .HasColumnType("longtext");

                    b.Property<string>("Smsapi")
                        .HasColumnType("longtext");

                    b.Property<string>("Smsno")
                        .HasColumnType("longtext");

                    b.Property<string>("Smspass")
                        .HasColumnType("longtext");

                    b.Property<string>("Smsuser")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Smsbilgi");
                });

            modelBuilder.Entity("MyCoreApp.Models.UserInvoices", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("Expire")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Kaciklama")
                        .HasColumnType("longtext");

                    b.Property<string>("Kmesaj")
                        .HasColumnType("longtext");

                    b.Property<string>("Mcoid")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Otarihi")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Packet")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("Peydate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Sms")
                        .HasColumnType("longtext");

                    b.Property<string>("Taciklama")
                        .HasColumnType("longtext");

                    b.Property<string>("Taksit")
                        .HasColumnType("longtext");

                    b.Property<string>("Tdurum")
                        .HasColumnType("longtext");

                    b.Property<int?>("Tekrar")
                        .HasColumnType("int");

                    b.Property<string>("Tyapan")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserInvoices");
                });

            modelBuilder.Entity("MyCoreApp.Models.UsersInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Accesspoint")
                        .HasColumnType("longtext");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Adurum")
                        .HasColumnType("longtext");

                    b.Property<string>("Anaadi")
                        .HasColumnType("longtext");

                    b.Property<string>("Anakizliksoyadi")
                        .HasColumnType("longtext");

                    b.Property<string>("Atipi")
                        .HasColumnType("longtext");

                    b.Property<string>("Babaadi")
                        .HasColumnType("longtext");

                    b.Property<int?>("Ciltno")
                        .HasColumnType("int");

                    b.Property<string>("Cinsiyet")
                        .HasColumnType("longtext");

                    b.Property<string>("Dogumtarihi")
                        .HasColumnType("longtext");

                    b.Property<string>("Dogumyeri")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ftipi")
                        .HasColumnType("longtext");

                    b.Property<string>("Kil")
                        .HasColumnType("longtext");

                    b.Property<string>("Kilce")
                        .HasColumnType("longtext");

                    b.Property<string>("Ksahibi")
                        .HasColumnType("longtext");

                    b.Property<string>("Kserino")
                        .HasColumnType("longtext");

                    b.Property<string>("Ktipi")
                        .HasColumnType("longtext");

                    b.Property<int?>("Kutukno")
                        .HasColumnType("int");

                    b.Property<string>("Kverildigitarih")
                        .HasColumnType("longtext");

                    b.Property<string>("Kverildigiyer")
                        .HasColumnType("longtext");

                    b.Property<string>("Lastname")
                        .HasColumnType("longtext");

                    b.Property<string>("Mahkoy")
                        .HasColumnType("longtext");

                    b.Property<string>("Meslek")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Osifre")
                        .HasColumnType("longtext");

                    b.Property<string>("Packet")
                        .HasColumnType("longtext");

                    b.Property<int?>("Pasaportno")
                        .HasColumnType("int");

                    b.Property<string>("Phone1")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone2")
                        .HasColumnType("longtext");

                    b.Property<string>("Phone3")
                        .HasColumnType("longtext");

                    b.Property<string>("Sabitip")
                        .HasColumnType("longtext");

                    b.Property<int?>("Sayfano")
                        .HasColumnType("int");

                    b.Property<int?>("Tadresno")
                        .HasColumnType("int");

                    b.Property<string>("Tc")
                        .HasColumnType("longtext");

                    b.Property<string>("Tcadde")
                        .HasColumnType("longtext");

                    b.Property<string>("Tdiskapino")
                        .HasColumnType("longtext");

                    b.Property<string>("Tickapino")
                        .HasColumnType("longtext");

                    b.Property<string>("Til")
                        .HasColumnType("longtext");

                    b.Property<string>("Tilce")
                        .HasColumnType("longtext");

                    b.Property<string>("Tmahalle")
                        .HasColumnType("longtext");

                    b.Property<int?>("Tpostano")
                        .HasColumnType("int");

                    b.Property<string>("Unvan")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.Property<string>("Uyruk")
                        .HasColumnType("longtext");

                    b.Property<string>("Vergidairesi")
                        .HasColumnType("longtext");

                    b.Property<int?>("Vergino")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UsersInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
