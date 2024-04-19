using Ardalis.Result;

namespace SharePrompts.UseCases.Contributors.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateContributorCommand(string Name, string? PhoneNumber) : SharePrompts.SharedKernel.ICommand<Result<int>>;
