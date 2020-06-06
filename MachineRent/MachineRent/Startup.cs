using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Context;
using MachineRent.Services;
using MachineRent.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MachineRent
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup()
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile("appsettings.json").AddEnvironmentVariables("MACHINERENTAPP_");
            Configuration = config.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddDbContext<MachineRentContext>(builder => builder.UseSqlServer(Configuration.GetConnectionString("SQL")));

            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<MachineRentContext>();

            services.AddScoped<IMachinesService, MachinesService>();
            services.AddScoped<IReservationService, ReservationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
