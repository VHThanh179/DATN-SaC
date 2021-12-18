using API.Hubs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Share.Helpers;
using Share.Interfaces;
using Share.Models;
using Share.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API
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
            services.AddSignalR();

            //fix loi Json loop
            services.AddControllers()
                .AddJsonOptions(o => o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidAudience = Configuration["Jwt:Audience"],
                        ValidIssuer = Configuration["Jwt:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                    };
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                   {
                     new OpenApiSecurityScheme
                     {
                       Reference = new OpenApiReference
                       {
                         Type = ReferenceType.SecurityScheme,
                         Id = "Bearer"
                       }
                      },
                      new string[] { }
                    }
                  });
            });
            services.AddDbContextPool<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")
                , b => b.MigrationsAssembly("Server")));

            services.Configure<TokenSettings>(Configuration.GetSection("Jwt"));

            services.AddTransient<IEncodeHelper, EncodeHelper>();
            //services.AddTransient<IUploadHelper, UploadHelper>();

            services.AddTransient<IProductSvc, ProductSvc>();

            services.AddTransient<ICustomerSvc, CustomerSvc>();

            services.AddTransient<IUserSvc, UserSvc>();

            services.AddTransient<IOrderDetailsSvc, OrderDetailsSvc>();

            services.AddTransient<IOrderSvc, OrderSvc>();

            services.AddTransient<IVoucherSvc, VoucherSvc>();

            services.AddTransient<IShipInfoSvc, ShipInfoSvc>();

            services.AddTransient<IAccountLogic, AccountLogic>();

            services.AddTransient<IActivity, ActivitySvc>();

            services.AddCors(options => options.AddPolicy(
                  "_mypolicy", builder => builder
                  .AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader()
              )
               );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();
             app.UseCors("_mypolicy");
            app.UseAuthentication();
            app.UseAuthorization();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<NotiHub>("/api/NewNoti");
                endpoints.MapControllers();
            });
        }
    }
}
