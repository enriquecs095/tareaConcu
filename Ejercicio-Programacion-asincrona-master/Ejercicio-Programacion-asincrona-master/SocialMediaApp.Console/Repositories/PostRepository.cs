using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SocialMediaApp.Console.Models;

namespace SocialMediaApp.Console.Repositories
{
    public class PostRepository
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        public IReadOnlyList<Post> GetByUserId(int userId)
        {
            Task.Delay(8000).Wait();
            var client = new WebClient();

            var content = client.DownloadString($"{Url}/?userId={userId}");

            return JsonConvert.DeserializeObject<IReadOnlyList<Post>>(content);
        }
    }
}
