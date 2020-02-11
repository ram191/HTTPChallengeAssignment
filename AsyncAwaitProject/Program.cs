using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace AsyncAwaitProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ////NumberTwo
            //Console.WriteLine(await RichEmployees());
            //Console.WriteLine(await LivesInJakarta());
            //Console.WriteLine(await BornOnMarch());
            //Console.WriteLine(await RndEmployees());
            //Console.WriteLine(await TotalAbsences());

            //Console.WriteLine(await NumberThree.GetData());
            // Create Object From Hello Scrape class
            //WebScrapes.ParseBirdsOfPrey();

            //Console.WriteLine(await NumberThree.GetData());
            Console.WriteLine(await MovieDbApi.GetIndonesian());
            Console.WriteLine(await MovieDbApi.GetKeanu());
            Console.WriteLine(await MovieDbApi.GetGood2016());
            Console.WriteLine(await MovieDbApi.GetRobertAndTom());
        }
    }




}
