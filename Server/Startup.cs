using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Server.Data;
using Share.Helpers;
using Share.Interfaces;
using Share.Models;
using Share.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Blazored.Modal;
using Blazored.Toast;

namespace Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(opt =>
            {
                opt.CheckConsentNeeded = content => true;
                opt.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            services.AddBlazoredToast();
            services.AddBlazoredModal();
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddSingleton(Configuration.GetSection("MailSettings").Get<MailSettings>());

            services.AddDbContextPool<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")
                , b => b.MigrationsAssembly("Server")));
            services.AddTransient<IProductSvc, ProductSvc>();
            services.AddTransient<IEncodeHelper, EncodeHelper>();
            services.AddTransient<IUserSvc, UserSvc>();
            services.AddTransient<IOrderSvc, OrderSvc>();
            services.AddTransient<IVoucherSvc, VoucherSvc>();
            services.AddTransient<IShipInfoSvc, ShipInfoSvc>();
            services.AddTransient<IOrderDetailsSvc, OrderDetailsSvc>();
            services.AddTransient<ICustomerSvc, CustomerSvc>();
            services.AddTransient<IStatisticalSvc, StatisticalSvc>();


            services.AddHttpContextAccessor();
            services.AddScoped<HttpContextAccessor>();
            services.AddHttpClient();
            services.AddScoped<HttpClient>();
            services.AddScoped<IMailSvc, MailSvc>();

            //syncfusion
            services.AddSyncfusionBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTI3NzMyQDMxMzkyZTMzMmUzMENjWmFkNktSdXQ0REpjVnRRUHJ5TUVNbXRBUGVDSzY2aWZvUXBmT05pVVE9");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
