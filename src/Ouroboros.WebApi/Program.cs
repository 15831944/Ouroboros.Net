using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ouroboros.DbContexts;
using Ouroboros.UnitOfWork;

namespace Ouroboros.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var host = CreateHostBuilder(args).Build();
                using (IServiceScope scope = host.Services.CreateScope())
                {
                    //初始化数据库
                    DBSeed.Initialize(scope.ServiceProvider.GetRequiredService<IUnitOfWork<MSDbContext>>());
                }
                host.Run();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
