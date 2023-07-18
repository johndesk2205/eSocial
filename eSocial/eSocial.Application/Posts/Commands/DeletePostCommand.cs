

using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.Commands
{
    public class DeletePostCommand : IRequest<Post>
    {
        public int PostId { get; set; }

    }
}