using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PFSC.Entities.PFSC_DBContext;
using PFSC.Services.Abstract.Factory;
using PFSC.Services.Abstract.Security;
using PFSC.Services.Concrete.Factory;
using PFSC.Services.Concrete.Security;
using PFSC.Services.Concrete.Search;
using PFSC.Services.Abstract.Search;

namespace PFSC_WebUI
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
            services.AddDbContext<PfscDbContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("PFSC_Connection")));

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = new PathString("/Account/Login");
                options.ExpireTimeSpan = new TimeSpan(1, 0, 0);
            });

            services.AddTransient<IPfscAuthenticationService, PfscAuthenticationService>();
            services.AddTransient<IFactoryService, FactoryService>();
            services.AddTransient<ISearchService, SearchService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();


            app.UseMvc(routes =>
            {

                routes.MapRoute("login", "login", defaults: new { controller = "Account", action = "Login" });
                routes.MapRoute("register", "register", defaults: new { controller = "Account", action = "Register" });
                routes.MapRoute("search", "search/{criteria?}", defaults: new { controller = "Search", action = "Index" });
                routes.MapRoute("getProduction", "getProduction", defaults: new { controller = "Search", action = "GetProduction" });
                routes.MapRoute("getTechnologies", "getTechnologies", defaults: new { controller = "Search", action = "GetTechnologies" });
                routes.MapRoute("factoriesForAutocomplete", "factoriesForAutocomplete/{searchCriteria}",
                    defaults: new {controller = "Search", action = "FactoriesForAutocomplete", searchCriteria = string.Empty });
                routes.MapRoute("factory", "factory/{factoryId}",
                    defaults: new {controller = "Factory", action = "Index"});
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");


                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Search", action = "Index" });
            });
        }
    }
}
