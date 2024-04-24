using Ardalis.GuardClauses;
using SharePrompts.SharedKernel;
using SharePrompts.Core.Interfaces;
using SharePrompts.Core.Services;
using SharePrompts.Infrastructure.Data;
using SharePrompts.Infrastructure.Data.Queries;
using SharePrompts.Infrastructure.Email;
using SharePrompts.UseCases.Contributors.List;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace SharePrompts.Infrastructure;
public static class InfrastructureServiceExtensions
{
  public static IServiceCollection AddInfrastructureServices(
    this IServiceCollection services,
    ConfigurationManager config,
    ILogger logger)
  {
    // choose connection string (DefaultConnection or CustomConnection)
    string? connectionString = config.GetConnectionString("CustomConnection");
    Guard.Against.Null(connectionString);
    services.AddApplicationDbContext(connectionString);

    //services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
    //services.AddScoped(typeof(IReadRepository<>), typeof(EfRepository<>));
    services.AddScoped<IListContributorsQueryService, ListContributorsQueryService>();
    services.AddScoped<IDeleteContributorService, DeleteContributorService>();

    services.Configure<MailserverConfiguration>(config.GetSection("Mailserver"));

    logger.LogInformation("{Project} services registered", "Infrastructure");

    return services;
  }
}
