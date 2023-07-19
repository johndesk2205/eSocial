using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eSocial.UI.Models;

namespace eSocial.UI
{
    public class PostClient
    {
        private readonly HttpClient http;

        public PostClient(HttpClient http)
        {
            this.http = http;
        }
        public async Task<ICollection<Post>> GetAllPosts()
        {
            return await http.GetFromJsonAsync<ICollection<Post>>("/api/posts");
        }
    }
}