using Microsoft.Extensions.Hosting;
using FluentScheduler;
using JobScheduler.Jobs;
using JobScheduler.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JobScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseWindowsService()
                .ConfigureServices(ConfigureServicesDelegate);

        private static void ConfigureServicesDelegate(HostBuilderContext hostingContext, IServiceCollection services)
        {
            services.AddScoped<ISayHiService, SayHiService>();

            var serviceProvider = services.BuildServiceProvider();
            JobManager.Initialize(new JobRegistry(serviceProvider));
        }
    }
}
