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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoAPIEstudo.Infraestruture.Contexto;
using Microsoft.Net.Http.Headers;

namespace ProjetoAPIEstudo
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigims = "MyAllowSpecificOrigims";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ProjetoAIEstudoContexto>(opts => opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddControllers();
            services.AddCors(options =>
                      options.AddPolicy(name: MyAllowSpecificOrigims,
                      builder =>
                      {
                          builder.WithOrigins("http://example.com",
                                       "http://www.contoso.com",
                                       "https://cors1.azurewebsites.net",
                                       "https://cors3.azurewebsites.net",
                                       "https://localhost:44386",
                                       "https://localhost:44386")
                          .WithHeaders(HeaderNames.ContentType, "x-custom-header")
                          .WithMethods("PUT", "DELETE", "GET", "OPTIONS");
                      }));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjetoAPIEstudo", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjetoAPIEstudo v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
