using Ardalis.Result;
using SharePrompts.SharedKernel;

namespace SharePrompts.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
