using AnyTongue.Persistence;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace AnyTongue.MigrationsConsole;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((c, cb) => ConfigureApp(c, cb, args))
            .ConfigureServices(ConfigureServices)
            .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));

        var host = builder.Build();

        using var scope = host.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

        await context.Database.MigrateAsync();
    }

    private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        var connectionString = context.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
    }

    private static void ConfigureApp(HostBuilderContext context, IConfigurationBuilder configBuilder, string[] args)
    {
        configBuilder.Sources.Clear();
        configBuilder.AddJsonFile("appsettings.json", false, true);
        configBuilder.AddEnvironmentVariables();
        configBuilder.AddCommandLine(args);
        configBuilder.AddUserSecrets<Program>(true);
    }
}