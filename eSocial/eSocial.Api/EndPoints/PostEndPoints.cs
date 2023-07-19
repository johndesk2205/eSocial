
using eSocial.Application.Posts.QueryHandlers;
using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using MediatR;

namespace eSocial.Api.EndPoints
{
    public static class PostEndPoints
    {
        public static void ConfigurePostEndpoints(this WebApplication app)
        {
            app.MapGet("/api/posts", async (IMediator mediator, IPostRepository postRepo) =>
            {
                // var result = await mediator.Send(new GetAllPostHandler());
                var result = await postRepo.GetAllPost();
                return result;
            });

            app.MapGet("/api/posts/{id}", async (int id, IPostRepository postRepo) =>
            {
                return await postRepo.GetById(id);
            });

            app.MapPost("/app/posts", async (Post post, IPostRepository postRepo) =>
            {
                return await postRepo.Create(post);
            });

            app.MapPut("/api/posts/{id}", async (Post post, int id, IPostRepository postRepo) =>
            {

                var result = await postRepo.Update(post, id);
                return result;
            });

            app.MapDelete("/api/posts/{id}", async (int id, IPostRepository postRepo) =>
            {
                var result = await postRepo.GetById(id);
                await postRepo.Delete(result);
                return result;
            });
        }
    }
}