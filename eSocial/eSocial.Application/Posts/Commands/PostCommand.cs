

using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.Commands
{
    public abstract class PostCommand : IRequest<Post>
    {
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}