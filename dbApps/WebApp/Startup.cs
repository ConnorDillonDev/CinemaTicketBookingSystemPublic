using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore; 
using UWS.CinemaTicketBookingSystem;


namespace CinemaTicketBookingSystem
{
    public class Startup
    {

        public Startup(IConfiguration configuration){
            Configuration = configuration;
        }

        public IConfiguration Configuration { get;}

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddAuthentication("MyCookieAuth").AddCookie("MyCookieAuth", options => {
                options.Cookie.Name = "MyCookieAuth";
                options.LoginPath = "/Login/Login";
                options.AccessDeniedPath = "/AccessDenied/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(120); //2 hour cookie expiary
            });


            services.AddAuthorization(options => {
                options.AddPolicy("MustBelongToStaff", policy => policy.RequireClaim("IsStaff", "TRUE"));
                options.AddPolicy("MustBelongToCustomer", policy => policy.RequireClaim("IsCustomer", "TRUE")); 
                options.AddPolicy("MustBelongToSuperUser", policy => policy.RequireClaim("IsSuperUser", "TRUE"));
            });


            services.AddRazorPages()
                .AddMvcOptions(options =>
                {
                    options.MaxModelValidationErrors = 50;
                    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
                    _ => "The field is required.");
                });


            string databasePath = Path.Combine("..", "Cinema.db");
            
            services.AddDbContext<Cinema>(options => options.UseSqlite($"Data Source={databasePath}"));


        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            

            app.UseDefaultFiles();

            app.UseStaticFiles();

            app.UseRouting();

            //cookie assignmnet requirments
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}