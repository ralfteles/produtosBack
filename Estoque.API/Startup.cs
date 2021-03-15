using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque.API.Configuracao;
using Estoque.Repository.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Swashbuckle.Swagger;

namespace Estoque.API
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
            services.AddControllers().AddNewtonsoftJson();


            services.AddDbContext<ProdutoContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("bancoProduto")));

            services.AddCors(o => o.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            DependecyInjection.RegistrarServicos(services);

            //AutoMapper
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperConfig());

            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            //Swagger


            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo
                    {
                        Title = "Produtos API",
                        Version = "v1",
                        Description = "API para controle de produtos",
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact
                        {
                            Name = "Rafael Teles",
                            Email = "ralf_teles@hotmail.com",
                        },

                    });
            });


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("CorsPolicy");
            app.UseAuthentication();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api");
            });


        }
    }
}
