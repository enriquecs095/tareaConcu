using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SocialMediaApp.Console.Models;

namespace SocialMediaApp.Console.Repositories
{
    public class CommentRepository
    {
        private const string Url = "https://jsonplaceholder.typicode.com/comments";
        public IReadOnlyList<Comment> GetByPostId(int postId)
        {
            Task.Delay(5000).Wait();
            var client = new WebClient();

            var content = client.DownloadString($"{Url}/?userId={postId}");

            return JsonConvert.DeserializeObject<IReadOnlyList<Comment>>(content);
        }

    }
}
