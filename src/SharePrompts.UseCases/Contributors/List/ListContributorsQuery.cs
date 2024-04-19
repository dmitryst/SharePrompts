using Ardalis.Result;
using SharePrompts.SharedKernel;

namespace SharePrompts.UseCases.Contributors.List;

public record ListContributorsQuery(int? Skip, int? Take) : IQuery<Result<IEnumerable<ContributorDTO>>>;
