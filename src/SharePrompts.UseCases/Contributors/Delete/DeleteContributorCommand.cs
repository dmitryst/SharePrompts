using Ardalis.Result;
using SharePrompts.SharedKernel;

namespace SharePrompts.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
