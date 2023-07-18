

using System.ComponentModel.DataAnnotations;

namespace eSocial.Domain.Models
{
    public class Post
    {

        [Key] public int Id { get; set; }
        [MaxLength(300)] public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}