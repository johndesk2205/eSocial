
using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.Queries
{
    public class GetAllPostsQuery : IRequest<ICollection<Post>>
    {

    }
}