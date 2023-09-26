using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _9_11_ProjectPetShop_1.DB;
using _9_11_ProjectPetShop_1.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _9_11_ProjectPetShop_1
{
    public class Startup
    {
        private IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IRepository, MyRepository>();
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<PetsDbContext>(options => options.UseLazyLoadingProxies().UseSqlServer(connectionString));
            services.AddControllersWithViews();
        }
        public void Configure(IApplicationBuilder app,PetsDbContext ctx)
        {
            //ctx.Database.EnsureDeleted();
            //ctx.Database.EnsureCreated();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
