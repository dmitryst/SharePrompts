using Ardalis.Specification.EntityFrameworkCore;
using SharePrompts.Infrastructure.Cap.Data;
using SharePrompts.SharedKernel;

namespace SharePrompts.Infrastructure.Cap;
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
  public EfRepository(CustomDbContext dbContext): base(dbContext)
  {
  }
}
