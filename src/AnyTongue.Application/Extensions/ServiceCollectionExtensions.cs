using Microsoft.Extensions.DependencyInjection;

namespace AnyTongue.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(options => options.RegisterServicesFromAssembly(typeof(MediatRAssemblyMarker).Assembly));
    }
}
