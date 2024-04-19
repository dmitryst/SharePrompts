using Ardalis.GuardClauses;
using SharePrompts.SharedKernel;

namespace SharePrompts.Core.PostAggregate;

public class Post(string message) : EntityBase, IAggregateRoot
{
  public string Message { get; private set; } = Guard.Against.NullOrEmpty(message, nameof(message));

  public string? Tag { get; private set; }

  public Guid UserId { get; private set; }
}

//public class Post : EntityBase, IAggregateRoot
//{
//  public Post(string message)
//  {
//    Message = Guard.Against.NullOrEmpty(message, nameof(message));
//  }

//  public string Message { get; private set; }

//  public string? Tag { get; private set; }

//  public Guid UserId { get; private set; }
//}
