using Business.Abstract;
using Business.Concrete;
using DataAccess.Data;
using DataAccess.Repository.Abstract;
using DataAccess.Repository.Concrete;
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
using System.Net.Http;
using System.Threading.Tasks;

namespace WebAPI
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

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
            });

            //services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:HiperConnection"]));


            services.AddControllersWithViews();
            services.AddSession();
           // services.AddTransient<INewsRepository, NewsRepository>();
            
            services.AddDbContext<ProjectDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("HiperConnection")));

            services.AddMemoryCache();

            //services.AddSingleton<IBilancoService, BilancoService>();
            //services.AddSingleton<IBilancoRepository, BilancoRepository>();


            //services.AddSingleton<IEnumTuruService, EnumTuruService>();
            //services.AddSingleton<IEnumTuruRepository, EnumTuruRepository>();

            //services.AddSingleton<IGercekMusteriService, GercekMusteriService>();
            //services.AddSingleton<IGercekMusteriRepository, GercekMusteriRepository>();

            //services.AddSingleton<IMusteriService, MusteriService>();
            //services.AddSingleton<IMusteriRepository, MusteriRepository>();

            //services.AddSingleton<IMusteriKayitKanaliService, MusteriKayitKanaliService>();
            //services.AddSingleton<IMusteriKayitKanaliRepository, MusteriKayitKanaliRepository>();

            //services.AddSingleton<ITuzelMusteriService, TuzelMusteriService>();
            //services.AddSingleton<ITuzelMusteriRepository, TuzelMusteriRepository>();

            services.AddTransient<IBilancoRepository, BilancoRepository>();
            services.AddTransient<IBilancoService, BilancoService>();

            services.AddTransient<IEnumTuruRepository, EnumTuruRepository>();
            services.AddTransient<IEnumTuruService, EnumTuruService>();

            services.AddTransient<IGercekMusteriRepository, GercekMusteriRepository>();
            services.AddTransient<IGercekMusteriService, GercekMusteriService>();

            services.AddTransient<IMusteriKayitKanaliRepository, MusteriKayitKanaliRepository>();
            services.AddTransient<IMusteriKayitKanaliService, MusteriKayitKanaliService>();

            services.AddTransient<IMusteriRepository, MusteriRepository>();
            services.AddTransient<IMusteriService, MusteriService>();

            services.AddTransient<ITuzelMusteriRepository, TuzelMusteriRepository>();
            services.AddTransient<ITuzelMusteriService, TuzelMusteriService>();
            
           

            //services.AddDbContext<ProjectDbContext>(options =>
            //options.UseNpgsql(Configuration.GetConnectionString("Host=localhost;Database=HiperBankDB;Username=postgres;Password=g181210011")));
            //services.AddDbContext<ProjectDbContext>(o => o.UseNpgsql(Configuration.GetConnectionString("HiperDB")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void ConfigureBusinessServices(IServiceCollection services)
        {
           
        }
    }
}
