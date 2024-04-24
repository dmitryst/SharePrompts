using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SharePrompts.Core.Cap.PostAggregate;
using SharePrompts.Infrastructure.Data;
using SharePrompts.SharedKernel;

namespace SharePrompts.Infrastructure.Cap.Data;
public class CustomDbContext : AppDbContext
{
  public CustomDbContext(DbContextOptions<AppDbContext> options, IDomainEventDispatcher? dispatcher) : base(options, dispatcher)
  {
  }

  public DbSet<Post> Posts => Set<Post>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}
