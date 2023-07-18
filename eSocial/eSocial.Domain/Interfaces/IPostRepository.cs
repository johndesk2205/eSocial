
using eSocial.Domain.Models;

namespace eSocial.Domain.Interfaces
{
    public interface IPostRepository
    {
        Task<ICollection<Post>> GetAllPost();
        Task<Post> GetById(int id);
        Task<Post> Create(Post post);
        Task<Post> Update(string updateContent, int postId);
        Task Delete(int postId);

    }
}