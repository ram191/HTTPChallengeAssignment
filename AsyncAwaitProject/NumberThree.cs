﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AsyncAwaitProject.Models;
using Newtonsoft.Json;

namespace AsyncAwaitProject
{
    public class NumberThree
    {
        public static async Task<string> GetData()
        {
            string data1 = await Fetcher.Get("https://jsonplaceholder.typicode.com/users");
            string data2 = await Fetcher.Get("https://jsonplaceholder.typicode.com/posts");
            var jObj1 = JsonConvert.DeserializeObject<List<User>>(data1);
            var jObj2 = JsonConvert.DeserializeObject<List<Post>>(data2);

            foreach(var unit in jObj2)
            {
                foreach(var id in jObj1)
                {
                    var x = id.id;
                    if(unit.id == x)
                    {
                        unit.user = new User()
                        {
                            id = id.id,
                            name = id.name,
                            username = id.username,
                            email = id.email,
                            address = id.address,
                            phone = id.phone,
                            website = id.website,
                            company = id.company
                        };
                    }
                }
            }
            var result = JsonConvert.SerializeObject(jObj2);
            return result;
        }
    }

    public class MovieDbApi
    {
        public static async Task<string> GetIndonesian()
        {
            string data1 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=11d617af2baf70b6f444703fb9c1ed5a&language=en-US&sort_by=popularity.desc&include_adult=true&include_video=false&with_original_language=id");
            var jObj = JsonConvert.DeserializeObject<MovieResult>(data1);
            var movies = new List<string>();

            var res = jObj.results;

            foreach (var item in res)
            {
                movies.Add(item.title);
            }

            return String.Join(", ", movies);
        }

        public static async Task<string> GetKeanu()
        {
            string data1 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=11d617af2baf70b6f444703fb9c1ed5a&language=en-US&sort_by=popularity.desc&include_adult=false&include_video=false&page=1&with_cast=6384");
            var jObj = JsonConvert.DeserializeObject<MovieResult>(data1);
            var movies = new List<string>();

            var res = jObj.results;

            foreach(var item in res)
            {
                movies.Add(item.title);
            }

            return String.Join(", ", movies);
        }

        public static async Task<string> GetRobertAndTom()
        {
            string data1 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=11d617af2baf70b6f444703fb9c1ed5a&language=en-US&include_adult=true&include_video=false&with_cast=3223&with_cast=1136406");
            var jObj = JsonConvert.DeserializeObject<MovieResult>(data1);
            var movies = new List<string>();

            var res = jObj.results;

            foreach (var item in res)
            {
                movies.Add(item.title);
            }

            return String.Join(", ", movies);
        }

        public static async Task<string> GetGood2016()
        {
            string data1 = await Fetcher.Get("https://api.themoviedb.org/3/discover/movie?api_key=11d617af2baf70b6f444703fb9c1ed5a&language=en-US&sort_by=popularity.desc&include_adult=true&include_video=false&year=2016&vote_average.gte=7.5");
            var jObj = JsonConvert.DeserializeObject<MovieResult>(data1);
            var movies = new List<string>();

            var res = jObj.results;

            foreach (var item in res)
            {
                movies.Add(item.title);
            }

            return String.Join(", ", movies);
        }
    }
}
