using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using IronWebScraper;
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

            Console.WriteLine(await NumberThree.GetData());

        }




    }

    class Scraper : WebScraper
    {
        public override void Init()
        {
            this.LoggingLevel = WebScraper.LogLevel.All;
            this.Request("https://kompas.com", Parse);
        }

        public override void Parse(Response response)
        {
            foreach (var css1 in response.Css("latest ga--latest mt2 clearfix"))
            {
                string title = css1.TextContentClean;
            }
        }
    }


}
