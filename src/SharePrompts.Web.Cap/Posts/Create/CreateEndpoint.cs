﻿using FastEndpoints;
using MediatR;
using SharePrompts.UseCases.Cap.Posts.Create;

namespace SharePrompts.Web.Cap.Posts.Create;

public class CreateEndpoint(IMediator _mediator) : Endpoint<CreatePostRequest, CreatePostResponse>
{
  public override void Configure()
  {
    Post("/posts");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CreatePostRequest req, CancellationToken ct)
  {
    var result = await _mediator.Send(new CreatePostCommand(req.Title, req.Text, req.Tag, req.UserId), ct);

    if (result.IsSuccess)
    {
      Response = new CreatePostResponse(result.Value.Id, req.Title, req.Text, req.Tag);
      return;
    }
  }
}
