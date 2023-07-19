

using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.Commands
{
    public class UpdatePostCommand : IRequest<Post>
    {
        public int PostId { get; set; }
        public Post? postContent { get; set; }

    }
}