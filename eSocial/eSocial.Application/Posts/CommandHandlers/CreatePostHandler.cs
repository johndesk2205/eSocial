using eSocial.Application.Posts.Commands;
using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.CommandHandlers
{
    public class CreatePostHandler : IRequestHandler<CreatePostCommand, Post>
    {
        private readonly IPostRepository postRepo;

        public CreatePostHandler(IPostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        public async Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var newPost = new Post
            {
                Content = request.PostContent
            };
            return await postRepo.Create(newPost);
        }
    }
}