using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Http;
using MyCoreApp.Data;
//using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Net;
//using OracleInternal.SqlAndPlsqlParser;
//using OracleInternal.SqlAndPlsqlParser.LocalParsing;
//using Oracle.EntityFrameworkCore.Infrastructure;
namespace MyCoreApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddControllersWithViews();
            //services.AddEntityFrameworkOracle();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.All;

                foreach (var proxy in Configuration.GetSection("KnownProxies").AsEnumerable().Where(c => c.Value != null))
                {
                    options.KnownProxies.Add(IPAddress.Parse(proxy.Value));
                }
            });
            services.AddHttpClient();
            services.AddHttpClient<HttpContext>();
            services.AddDbContextPool<ApplicationDbContext>(options => options.UseOracle(Configuration.GetConnectionString("DefaultConnection")));
            // services.AddDbContext<ApplicationDbContext>(options => options.UseOracle(
            //     "DATA SOURCE=192.168.2.253/orcl; PASSWORD=a4s3d2f1; USER ID=YATANHASTA;     PERSIST SECURITY INFO=True;",
            //    ServerVersion.AutoDetect("DATA SOURCE=192.168.2.253/orcl; PASSWORD=a4s3d2f1; USER ID=YATANHASTA;     PERSIST SECURITY INFO=True;")
            //));
          //  services.AddDbContext<ApplicationDbContext>(options => options.UseOracle(
           //      "DATA SOURCE=192.168.2.253/orcl; PASSWORD=a4s3d2f1; USER ID=YATANHASTA;     PERSIST SECURITY INFO=True;"),
           // ServerVersion.AutoDetect("DATA SOURCE=192.168.2.253/orcl; PASSWORD=a4s3d2f1; USER ID=YATANHASTA;     PERSIST SECURITY INFO=True;")));

            //return OracleConnection();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseForwardedHeaders();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login}/{action=Index}/{id?}");
            });
        }
    }
}
