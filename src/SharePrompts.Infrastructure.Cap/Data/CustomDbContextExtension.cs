using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SharePrompts.Infrastructure.Cap.Data;

public static class CustomDbContextExtension
{
  public static void AddCustomDbContext(this IServiceCollection services, string connectionString)
  {
    services.AddDbContext<CustomDbContext>(options =>
         options.UseNpgsql(connectionString));
  }
}
