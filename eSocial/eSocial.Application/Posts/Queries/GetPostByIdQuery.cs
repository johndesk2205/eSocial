

using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.Queries
{
    public class GetPostByIdQuery : IRequest<Post>
    {
        public int PostId { get; set; }
    }
}