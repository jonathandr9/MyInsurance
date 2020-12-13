using HinovaProvaAdapter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyInsurance.Application;
using MyInsurance.Domain.Adapters;
using MyInsurance.Domain.Services;
using AutoMapper;

namespace MyInsurance.WebApplication
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
            services.AddAutoMapper(typeof(HinovaProfile));

            services.AddControllersWithViews();
            services.AddScoped<IHinovaAdapter, HinovaAdapter>();
            services.AddScoped<IOficinaService, OficinaService>();

            //services.AddApplication
            //   (Configuration.SafeGet<ApplicationConfiguration>());

            //services.AddAtomicsAdapter
            //    (Configuration.SafeGet<AtomicsAdapterConfiguration>());

            services.AddSingleton<IConfiguration>(Configuration);

            var preciseConfig = Configuration.GetSection("HinovaAdapterConfiguration").Get<HinovaAdapterConfiguration>();
              //Configuration.GetSection("HinovaAdapterConfiguration:root:inner").Bind(preciseConfig);

            services.AddHinovaAdapter(preciseConfig);

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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
