namespace SharePrompts.Web.Cap.Posts.Create;

public class CreatePostRequest
{
    public required string Title { get; set; }

    public required string Text { get; set; }

    public string? Tag { get; set; }

    public Guid UserId { get; set; }
}
