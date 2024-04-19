using Ardalis.Result;
using SharePrompts.SharedKernel;

namespace SharePrompts.UseCases.Contributors.Update;

public record UpdateContributorCommand(int ContributorId, string NewName) : ICommand<Result<ContributorDTO>>;
