using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AsyncAwaitProject
{
    public class NumberThree
    {
        public static async Task<string> GetData()
        {
            var client = new HttpClient();
            var data1 = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var data2 = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
            var jObj1 = JsonConvert.DeserializeObject<List<User>>(data1);
            var jObj2 = JsonConvert.DeserializeObject<List<Post>>(data2);
            var jObj3 = new List<List<NumberThreeClass>>();
            var names = new List<string>();

            var newList =
                from x in jObj1
                join y in jObj2 on x.id equals y.id
                where x.id == y.id
                select new
                {
                   y.userId,
                   y.id,
                   y.title,
                   y.body,
                   x.name,
                   x.username,
                   x.email,
                   x.address,
                   x.address.street,
                   x.address.suite,
                   x.address.city,


                };

            var result = JsonConvert.SerializeObject(newList);
            return result;
        }
    }
}
