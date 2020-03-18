using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lyra.WebAPI.Database;
using Lyra.WebAPI.Filters;
using Lyra.WebAPI.Services;
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
using AutoMapper;
using Lyra.Model.Requests;

namespace Lyra.WebAPI
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
            services.AddDbContext<LyraContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("LyraDev")));
            
            services.AddControllers(x => x.Filters.Add<ErrorFilter>());
            
            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Lyra API", Version = "v1" });
            });

            services.AddScoped<IBaseService<Model.Album, AlbumSearchRequest>, AlbumService>();
            services.AddScoped<ICRUDService<Model.Artist, object, object, object>, ArtistService>();
            services.AddScoped<ICRUDService<Model.Track, TrackSearchRequest, TrackInsertRequest, object>, TrackService>();
            services.AddScoped<ICRUDService<Model.Playlist, object, object, object>, PlaylistService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Lyra API V1");
                
            });
        }
    }
}
