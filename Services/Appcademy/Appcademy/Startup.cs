using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appcademy.Context;
using Appcademy.Interfaces;
using Appcademy.Lib;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Appcademy
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
          services.AddSingleton<IFileLib, FileLib>();
          services.AddSingleton<ICourseLib, CourseLib>();

      services.AddDbContext<ApplicationDbContext>(
            options => options.UseMySql(Configuration.GetConnectionString("DefaultConnection"))
          );

          //Avoid cyclic references
          services.AddControllers()
            .AddNewtonsoftJson(options =>
              options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore 
          );

          // Ignore empty Json values
          services.AddMvc(c => { })
            .AddNewtonsoftJson(options =>
            {
              options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            });

          // Enabling CORS
          services.AddCors(c =>
          {
            c.AddPolicy("AllowOrigin", options => {
              options.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader();
            });          

      });

    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enabling CORS
            app.UseCors("AllowOrigin");
            app.UseHttpsRedirection();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
