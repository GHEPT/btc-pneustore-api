using Equipe2_PneuStore.Data;
using Equipe2_PneuStore.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Equipe2_PneuStore
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

            services.AddCors();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Equipe2_BTC_PneuStore",
                        Description = "An API created to the bootcamp of the PneuStore BackEnd side.",
                        Contact = new OpenApiContact
                        {
                            Name = "Eduardo Meireles, Eduardo Teodoro, Josué Barros e Thales Ribeiro",
                            Url = new Uri("https://github.com/CodeThales/btc-pneustore-api/blob/main/README.md"),
                        },

                        License = new OpenApiLicense
                        {
                            Name = "API License - https://www.pneustore.com.br",
                            Url = new Uri("https://www.pneustore.com.br"),
                        },
                        Version = "v1"
                    });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = $"{Path.Combine(AppContext.BaseDirectory, xmlFile)}";
                c.IncludeXmlComments(xmlPath);

            });

                services.AddDbContext<Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PneuStore"))
            );

            #region Dependency Injection
            services.AddTransient<ITyreService, TyreService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IPartnerService, PartnerService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IClientService, ClientService>();
  

            services.AddDefaultIdentity<IdentityUser>()                
                .AddEntityFrameworkStores<Context>();
            #endregion

            #region Configure Bearer Authentication
            var key = Encoding.ASCII.GetBytes(Configuration["Jwt:Key"]);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            #endregion
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Equipe2_PneuStore v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
