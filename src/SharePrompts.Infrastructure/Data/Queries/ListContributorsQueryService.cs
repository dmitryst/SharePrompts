using SharePrompts.UseCases.Contributors;
using SharePrompts.UseCases.Contributors.List;
using Microsoft.EntityFrameworkCore;
using SharePrompts.Core.ContributorAggregate;

namespace SharePrompts.Infrastructure.Data.Queries;

public class ListContributorsQueryService(AppDbContext _db) : IListContributorsQueryService
{
  // You can use EF, Dapper, SqlClient, etc. for queries -
  // this is just an example

  public async Task<IEnumerable<ContributorDTO>> ListAsync()
  {
    var result = await _db.Contributors
      .Select(c => new ContributorDTO(c.Id, c.Name, ExtractPhoneNumber(c)))
      .ToListAsync();

    return result;
  }

  private static string? ExtractPhoneNumber(Contributor c)
  {
    return c.PhoneNumber?.Number ?? string.Empty;
  }
}
