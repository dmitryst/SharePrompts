namespace SharePrompts.Web.Cap.Posts.Create;
public class CreatePostResponse(int id, string title, string text, string? tag)
{
  public int Id { get; set; } = id;

  public string Title { get; set; } = title;

  public string Text { get; set; } = text;

  public string? Tag { get; set; } = tag;
}
