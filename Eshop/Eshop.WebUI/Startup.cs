using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshop.WebUI.Repository.Abstract;
using Eshop.WebUI.Repository.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Eshop.WebUI
{
    public class Startup
    {

        public IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EshopContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddTransient<IProductRepository, EfProductRepository>();
            services.AddTransient<ICategoryRepository, EfCategoryRepository>();
            services.AddTransient<IUnitOfWork, EfUnitOfWork>();

            services.AddMvc();

            //session kullanacagımızı programa bildiriyoruz.
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStatusCodePages();

            //sessionu kullanmak istediğimizde gerekli ayarları yapsın diye
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "products",
                    template: "products/{category?}" ,
                defaults : new {  controller="Product" , action="List" });

               routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            SeedData.EnsurePopulated(app);
        }
    }
}
