using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSocial.Application.Posts.Commands;
using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Application.Posts.CommandHandlers
{
    public class DeletePostHandler : IRequestHandler<DeletePostCommand, Post>
    {
        private readonly IPostRepository postRepo;

        public DeletePostHandler(IPostRepository postRepo)
        {
            this.postRepo = postRepo ?? throw new ArgumentNullException(nameof(postRepo));
        }

        public async Task<Post> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {

            var itemId = await postRepo.GetById(request.PostId);
            await postRepo.Delete(itemId);
            return null!;
        }
    }

}