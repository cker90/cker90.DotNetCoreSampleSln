using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DataAccess;
using Services.ProductService;
using Microsoft.EntityFrameworkCore;
using Entity.Table;
using Arch.EntityFrameworkCore.UnitOfWork;

namespace Web
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
            // services.AddDbContext<SampleContext>(options =>
            // options.UseMySql(ServerVersion.AutoDetect(Configuration.GetConnectionString("MySqlConnection")), b => b.MigrationsAssembly("Web")));
 var connection = Configuration.GetConnectionString("MysqlConnection");  //这里的MysqlConnection要和appsettings中ConnectionStrings里面的MysqlConnection相同
services.AddDbContext<SampleContext>(options =>      //这是我目前找到的唯一一种在ConfigureServices里面配置Mysql服务
    options.UseMySql(
        connection,
        ServerVersion.AutoDetect(connection), b => b.MigrationsAssembly("Web")
    )
);
            services.AddUnitOfWork<SampleContext>();//添加UnitOfWork支持
            services.AddScoped(typeof(IProductService), typeof(ProductService));//用ASP.NET Core自带依赖注入(DI)注入使用的类
            

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
