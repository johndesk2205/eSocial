

using eSocial.Domain.Interfaces;
using eSocial.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace eSocial.Dal.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly Contexto db;

        public PostRepository(Contexto bd)
        {
            db = bd;
        }

        public async Task<ICollection<Post>> GetAllPost()
        {
            return await db.Posts.ToListAsync();
        }

        public async Task<Post> GetById(int id)
        {
            return await db.Posts.FirstOrDefaultAsync(p => p.Id == id);

        }

        public async Task<Post> Create(Post post)
        {
            post.CreatedAt = DateTime.Now;
            post.LastUpdate = DateTime.Now;
            db.Posts.Add(post);
            await db.SaveChangesAsync();

            return post;
        }

        public async Task<Post> Update(string updateContent, int postId)
        {
            var post = await db.Posts.FirstOrDefaultAsync(p => p.Id == postId);
            post.LastUpdate = DateTime.Now;
            post.Content = updateContent;
            await db.SaveChangesAsync();
            return post;
        }

        public async Task Delete(Post post)
        {
            db.Posts.Remove(post);
            await db.SaveChangesAsync();
        }


    }
}