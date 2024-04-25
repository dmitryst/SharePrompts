namespace SharePrompts.Web.Cap.Posts;

public class CreatePostRequest
{
  public const string Route = "/Posts";

  public required string Title { get; set; }

  public required string Text { get; set; }

  public string? Tag { get; set; }

  public Guid UserId { get; set; }
}
