
using eSocial.Application.Posts.Queries;
using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.QueryHandlers
{
    public class GetPostByIdHandler : IRequestHandler<GetPostByIdQuery, Post>
    {
        private readonly IPostRepository postRepo;
        public async Task<Post> Handle(GetPostByIdQuery request, CancellationToken cancellationToken)
        {
            return await postRepo.GetById(request.PostId);
        }
    }
}