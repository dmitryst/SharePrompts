using Ardalis.GuardClauses;
using SharePrompts.SharedKernel;

namespace SharePrompts.Core.Cap.PostAggregate;

public class Post(string title, string text, string? tag, Guid userId) : EntityBase, IAggregateRoot
{
  public string Title { get; private set; } = Guard.Against.NullOrEmpty(title, nameof(title));

  public string Text { get; private set; } = Guard.Against.NullOrEmpty(text, nameof(text));

  public string? Tag { get; private set; } = tag;

  public Guid UserId { get; private set; } = Guard.Against.NullOrEmpty(userId, nameof(userId));
}
