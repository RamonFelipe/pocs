using CorrelationApi.Configurations.Interfaces;
using CorrelationApi.Configurations;

namespace CorrerlationApi.Services;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCorrelationIdGeneratorService(this IServiceCollection services)
    {
        services.AddScoped<ICorrelationIdGenerator, CorrelationIdGenerator>();

        return services;
    }
}