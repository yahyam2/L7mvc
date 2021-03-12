////////////////////////////////////////////////////////////////////////////
// Date             Developer           Description:
// 2021-03-12      Yahya Mirzaei 

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using Microsoft.Extensions.DependencyInjection;


namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
        }

        //tinfo200:[2021-03-13-yahyam2-dykstra1]- 
        private static void CreateDbIfNotExists(IHost host)
        {

            //tinfo200:[2021-03-13-yahyam2-dykstra1]- 
            //tinfo200:[2021-03-13-yahyam2-dykstra1]- 
            //tinfo200:[2021-03-13-yahyam2-dykstra1]- 

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<SchoolContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

        //tinfo200:[2021-03-13-yahyam2-dykstra1]- Lambda reads goes to
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
