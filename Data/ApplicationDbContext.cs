using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyCoreApp.Models;
using Oracle.EntityFrameworkCore;

namespace MyCoreApp.Data
{
    public class ApplicationDbContext  : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<MyCoreApp.Models.Nas> Nas { get; set; }
        public DbSet<MyCoreApp.Models.UsersInfo> UsersInfo { get; set; }
        public DbSet<MyCoreApp.Models.AccessPoints> AccessPoints { get; set; }
        public DbSet<MyCoreApp.Models.Bakiye> Bakiye { get; set; }
        public DbSet<MyCoreApp.Models.Basvuru> Basvuru { get; set; }
        public DbSet<MyCoreApp.Models.BtkNat> BtkNat { get; set; }
        public DbSet<MyCoreApp.Models.Members> Members { get; set; }
        public DbSet<MyCoreApp.Models.MetroIp> MetroIp { get; set; }
        public DbSet<MyCoreApp.Models.PacketsInfo> PacketsInfo { get; set; }
        public DbSet<MyCoreApp.Models.Radacct> Radacct { get; set; }
        public DbSet<MyCoreApp.Models.Radcheck> Radcheck { get; set; }
        public DbSet<MyCoreApp.Models.Radgroupcheck> Radgroupcheck { get; set; }
        public DbSet<MyCoreApp.Models.Radgroupreply> Radgroupreply { get; set; }
        public DbSet<MyCoreApp.Models.Radippool> Radippool { get; set; }
        public DbSet<MyCoreApp.Models.Radpostauth> Radpostauth { get; set; }
        public DbSet<MyCoreApp.Models.Radreply> Radreply { get; set; }
        public DbSet<MyCoreApp.Models.Radusergroup> Radusergroup { get; set; }
        public DbSet<MyCoreApp.Models.Sayi> Sayi { get; set; }
        public DbSet<MyCoreApp.Models.Sms> Sms { get; set; }

        public DbSet<MyCoreApp.Models.Smsbilgi> Smsbilgi { get; set; }
        public DbSet<MyCoreApp.Models.UserInvoices> UserInvoices { get; set; }
        public DbSet<MyCoreApp.Models.TCNOIS> TCNOIS { get; set; }

    }
}
