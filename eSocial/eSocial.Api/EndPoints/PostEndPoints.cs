
using eSocial.Application.Posts.Commands;
using eSocial.Application.Posts.Queries;
using eSocial.Application.Posts.QueryHandlers;
using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eSocial.Api.EndPoints
{
    public static class PostEndPoints
    {
        public static void ConfigurePostEndpoints(this WebApplication app)
        {
            app.MapGet("/api/posts", GetAll);
            app.MapGet("/api/posts/{id}", GetById);
            app.MapPost("/app/posts", PostItem);
            app.MapPut("/api/posts", PutItem);
            app.MapDelete("/api/posts/", DeleteItem);

            #region Usando IPostRepository

            // app.MapGet("/api/postss", async (IPostRepository postRepo) =>
            // {

            //     var result = await postRepo.GetAllPost();
            //     return result;
            // });

            // app.MapGet("/api/posts/{id}", async (int id, IPostRepository postRepo) =>
            // {
            //     return await postRepo.GetById(id);
            // });


            // app.MapPost("/app/posts", async (Post post, IPostRepository postRepo) =>
            // {
            //     return await postRepo.Create(post);
            // });


            // app.MapPut("/api/posts/{id}", async (Post post, int id, IPostRepository postRepo) =>
            // {

            //     var result = await postRepo.Update(post, id);
            //     return result;
            // });


            // app.MapDelete("/api/posts/{id}", async (int id, IPostRepository postRepo) =>
            // {
            //     var result = await postRepo.GetById(id);
            //     await postRepo.Delete(result);
            //     return result;
            // });
            #endregion
        }

        #region Name


        //Delete
        private async static Task<IResult> DeleteItem([FromBody] DeletePostCommand deleteCommand, IMediator mediator)
        {
            var result = await mediator.Send(deleteCommand);
            return Results.Ok(result);
        }

        //Put
        private async static Task<IResult> PutItem([FromBody] UpdatePostCommand postCommand, IMediator mediator)
        {

            var result = await mediator.Send(postCommand);
            return Results.Ok(result);
        }

        // Post
        private async static Task<IResult> PostItem(CreatePostCommand post, IMediator mediator)
        {

            var result = await mediator.Send(post);
            return Results.Ok(result);
        }


        //Get All
        private async static Task<IResult> GetAll(IMediator mediator)
        {
            var result = new GetAllPostsQuery();
            var posts = await mediator.Send(result);
            if (posts is null) return Results.NotFound();
            return Results.Ok(posts);
        }

        //Get by ID using

        private async static Task<IResult> GetById(int id, IMediator mediator)
        {
            var command = new GetPostByIdQuery(id);
            var result = await mediator.Send(command);
            return Results.Ok(result);
        }
        #endregion


    }
}