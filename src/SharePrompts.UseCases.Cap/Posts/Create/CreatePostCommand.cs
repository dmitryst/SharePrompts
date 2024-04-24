using Ardalis.Result;
using SharePrompts.Core.Cap.PostAggregate;
using SharePrompts.SharedKernel;

namespace SharePrompts.UseCases.Cap.Posts.Create;

public record CreatePostCommand(string Title, string Text, string? Tag, Guid UserId) : ICommand<Result<Post>>;
