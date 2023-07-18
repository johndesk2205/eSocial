
using eSocial.Application.Posts.Commands;
using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.CommandHandlers
{
    public class UpdatePostHandler : IRequestHandler<UpdatePostCommand, Post>
    {
        private readonly IPostRepository postRepo;

        public UpdatePostHandler(IPostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        public async Task<Post> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var result = await postRepo.Update(request.postContent, request.PostId);
            return result;
        }
    }
}