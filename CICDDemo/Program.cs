using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CICDDemo.Models;
namespace CICDDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppDetails.ENV_DBConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            AppDetails.ENV_DeploymentEnvironment = Environment.GetEnvironmentVariable("DB_DEPLOYMENTENVIRONMENT");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
