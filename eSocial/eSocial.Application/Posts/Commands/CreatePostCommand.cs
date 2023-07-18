

using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.Commands
{
    public class CreatePostCommand : IRequest<Post>
    {
        public string? PostContent { get; set; }
    }
}