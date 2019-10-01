using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.AppCore.Interfaces;
using Acme.AppData;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Acme.AppAPI
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
            services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
            {
                builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
            }));

            services.AddTransient<IActivity, ActivityRepository>();
            services.AddTransient<ISignups, SignupRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);            
            ConfigureDevlopmentDatabase(services);
        }


        public void ConfigureDevlopmentDatabase(IServiceCollection services)
        {
            // This function will add context with local database.

            services.AddDbContext<ActivitySignupContext>(c =>
                c.UseSqlServer(Configuration.GetConnectionString("ActivitySignupDevConnection")));

        }

        public void ConfigureProductionDatabase(IServiceCollection services)
        {
            // This function will configure production database. 
            // TODO: Add configuration for production

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ActivitySignupContext activitySignupContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("ApiCorsPolicy");

            activitySignupContext.Database.EnsureCreated();

            app.UseMvc();
        }
    }
}
