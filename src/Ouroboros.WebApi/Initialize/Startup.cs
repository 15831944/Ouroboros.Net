using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ouroboros.Component.Aop;
using Ouroboros.DbContexts;
using Ouroboros.Models.Automapper;
using Ouroboros.Services;
using Ouroboros.UnitOfWork;
using Ouroboros.WebCore;

namespace Ouroboros.WebApi
{
    public class Startup
    {
        /*        public Startup(IConfiguration configuration)
                {
                    Configuration = configuration;
                }*/

        public ILifetimeScope AutofacContainer { get; private set; }

        public Startup(IWebHostEnvironment env)
        {
            // In ASP.NET Core 3.0 `env` will be an IWebHostingEnvironment, not IHostingEnvironment.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        /// <summary>
        /// ���autofac��DI��������
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            //ע��aop������ 
            //��ҵ���������ƴ��˽�ȥ����ҵ���ӿں�ʵ������ע�ᣬҲ��ҵ�������������˴���
            builder.AddAopService(ServiceExtensions.GetAssemblyName());
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //ע��������
            services.AddCorsPolicy(Configuration);

            //ע��webcore������վ��Ҫ���ã�
            services.AddWebCoreService(Configuration);

            //ע�Ṥ����Ԫ
            services.AddUnitOfWorkService<MSDbContext>(options => { options.UseMySql(Configuration.GetSection("ConectionStrings:MSDbContext").Value); });

            //ע��automapper����
            services.AddAutomapperService();

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

            //���������м��
            app.UseCors(WebCoreExtensions.MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
