using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dotnet.Models;
using MyCoreApp.Models;

namespace MyCoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<dotnet.Models.Nas> Nas { get; set; }
        public DbSet<MyCoreApp.Models.UsersInfo> UsersInfo { get; set; }
    }
}
