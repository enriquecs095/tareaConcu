using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SocialMediaApp.Console.Models;

namespace SocialMediaApp.Console.Repositories
{
    public  class UserRepository
    {
        private const string Url = "https://jsonplaceholder.typicode.com/users";
        public IReadOnlyList<User> Get()
        {
            Task.Delay(5000).Wait();
            var client = new WebClient();

            var content = client.DownloadString(Url);

            return JsonConvert.DeserializeObject<IReadOnlyList<User>>(content);
        }
    }
}
