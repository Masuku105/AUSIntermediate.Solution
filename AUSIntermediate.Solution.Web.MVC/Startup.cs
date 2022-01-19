using AUSIntermediate.Solution.RepositoryLayer.Repositories;
using AUSIntermediate.Solution.ServiceLayer;
using AUSIntermediate.Solution.ServiceLayer.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AUSIntermediate.Solution.BusinessLogicLayer;
using AUSIntermediate.Solution.BusinessLogicLayer.Services.UserBLL;
using AUSIntermediate.Solution.BusinessLogicLayer.Interfaces;
using AUSIntermediate.Solution.Web.MVC.Helpers;
using System.Reflection;
using AUSIntermediate.Solution.BusinessLogicLayer.Services.AddressBLL;

namespace AUSIntermediate.Solution.Web.MVC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AUSIntermediateDbContext>(options =>
            options.UseSqlServer(
                Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IUserRepositoryService, AddressRepositoryServic>();
            services.AddTransient<IUserBusinessLogic, UserBusinessLogic>();
            services.AddTransient<IAddressRepositoryService, AddressRepositoryService>();
            services.AddTransient<IAddressBusinessLogic, AddressBusinessLogic>();



            services.AddAutoMapper(typeof(BusinessMappingProfiles), typeof(MvcMappingProfiles));

            services.AddControllersWithViews();
            services.AddMvcCore();

           
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Index}/{id?}");
            });
        }
    }
}
