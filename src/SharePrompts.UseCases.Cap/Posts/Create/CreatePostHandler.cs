using Ardalis.Result;
using SharePrompts.Core.Cap.PostAggregate;
using SharePrompts.SharedKernel;

namespace SharePrompts.UseCases.Cap.Posts.Create;

public class CreatePostHandler(IRepository<Post> _repository) : ICommandHandler<CreatePostCommand, Result<Post>>
{
  public async Task<Result<Post>> Handle(CreatePostCommand request, CancellationToken cancellationToken)
  {
    var newPost = new Post(request.Title, request.Text, request.Tag, request.UserId);

    var createdPost = await _repository.AddAsync(newPost, cancellationToken);

    return createdPost;
  }
}
