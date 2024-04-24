using Ardalis.GuardClauses;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SharePrompts.SharedKernel;
using SharePrompts.Infrastructure.Cap.Data;

namespace SharePrompts.Infrastructure.Cap;
public static class InfrastructureServiceExtensions
{
  public static IServiceCollection AddCapInfrastructureServices(
    this IServiceCollection services,
    ConfigurationManager config,
    ILogger logger)
  {
    string? connectionString = config.GetConnectionString("CustomConnection");
    Guard.Against.Null(connectionString);
    services.AddCustomDbContext(connectionString);

    services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
    services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));

    logger.LogInformation("{Project} services registered", "Infrastructure");

    return services;
  }
}
