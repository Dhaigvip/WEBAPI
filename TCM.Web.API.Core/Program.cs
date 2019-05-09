using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;
using Unity;
using Unity.Microsoft.DependencyInjection;

namespace TCM.Web.API.Core
{
    public class Program
    {

        private static readonly IUnityContainer _container = new UnityContainer();
        public static void Main(string[] args)
        {
            //_container =
            //   UnityHelper.Container =
            //       UnityContainerSetUp.Configure(new UnityContainer(), "Common|XfmClient|WindowsService");

            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .CaptureStartupErrors(true)
                .UseUnityServiceProvider(_container)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .ConfigureAppConfiguration((builderContext, config) =>
                    {
                        var builtConfig = config.Build();
                        var configurationBuilder = new ConfigurationBuilder();
                        configurationBuilder.SetBasePath(builderContext.HostingEnvironment.ContentRootPath);
                        configurationBuilder.AddJsonFile($"appsettings.{builderContext.HostingEnvironment.EnvironmentName}.json", true, true);
                        configurationBuilder.AddJsonFile("ocelot.json");
                        configurationBuilder.AddJsonFile($"ocelot.{builderContext.HostingEnvironment.EnvironmentName}.json", true, true);
                        configurationBuilder.AddEnvironmentVariables();
                        config.AddConfiguration(configurationBuilder.Build());
                    })
                .UseStartup<Startup>();
        }
    }
}
