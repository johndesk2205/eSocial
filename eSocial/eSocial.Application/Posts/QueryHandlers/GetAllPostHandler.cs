

using eSocial.Application.Posts.Queries;
using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.QueryHandlers
{
    public class GetAllPostHandler : IRequestHandler<GetAllPostsQuery, ICollection<Post>>
    {
        private readonly IPostRepository postRepo;

        public GetAllPostHandler(IPostRepository postRepo)
        {
            this.postRepo = postRepo;
        }

        public async Task<ICollection<Post>> Handle(GetAllPostsQuery request, CancellationToken cancellationToken)
        {
            return await postRepo.GetAllPost();
        }
    }
}