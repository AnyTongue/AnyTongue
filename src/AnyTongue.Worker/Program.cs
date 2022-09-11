using AnyTongue.Application.Extensions;
using Coravel;
using Serilog;

namespace AnyTongue.Worker;

public class Program
{
    public static void Main(string[] args)
    {
        var host = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(ConfigureApp)
            .ConfigureServices(ConfigureServices)
            .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration))
            .UseWindowsService()
            .Build();

        host.Services.UseScheduler(scheduler =>
        {

        });

        host.Run();
    }

    private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddHostedService<Worker>();
        services.RegisterApplicationServices();
    }

    private static void ConfigureApp(HostBuilderContext context, IConfigurationBuilder configBuilder)
    {

    }
}