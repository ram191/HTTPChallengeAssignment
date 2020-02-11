using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncAwaitProject
{
    public class WebScrapes
    {
        public static void ParseKompas()
        {
            string html = @"https://kompas.com/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            HtmlNode[] unodes = htmlDoc.DocumentNode.SelectNodes("//a[@class='headline__thumb__link']").ToArray();
            HtmlNode[] hnodes = htmlDoc.DocumentNode.SelectNodes("//h2[@class='headline__thumb__title']").ToArray();

            var articles = new List<Articles>();
            for (int x = 0; x < unodes.Length; x++)
            {
                var title = hnodes[x].InnerText;
                var links = unodes[x].Attributes["href"].Value;

                var newArt = new Articles
                {
                    Title = title,
                    Url = links
                };

                articles.Add(newArt);
            }

            foreach (var x in articles)
            {
                Console.WriteLine(x.Title);
                Console.WriteLine(x.Url);
                Console.WriteLine("\n");
            }
        }

        public static void ParseBirdsOfPrey()
        {
            string html = @"https://www.cgv.id/en/movies/info/20000600";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            HtmlNode title = htmlDoc.DocumentNode.SelectNodes("//div[@class='movie-info-title']").First();
            HtmlNode [] jenisFilm = htmlDoc.DocumentNode.SelectNodes("//div[@class='movie-add-info left']").ToArray();
            HtmlNode desc = htmlDoc.DocumentNode.SelectNodes("//div[@class='movie-synopsis right']").First();

            Console.WriteLine(title.InnerHtml.Trim());
            foreach (var item in jenisFilm)
            {

                Console.WriteLine(item.InnerText.Trim().Replace("\t", string.Empty));
            }
            Console.WriteLine($"Synopsis: {desc.InnerText.Trim()}");
        }

        public static void ParseTheTurning()
        {
            string html = @"https://www.cgv.id/en/movies/info/20002700";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            HtmlNode title = htmlDoc.DocumentNode.SelectNodes("//div[@class='movie-info-title']").First();
            HtmlNode[] jenisFilm = htmlDoc.DocumentNode.SelectNodes("//div[@class='movie-add-info left']").ToArray();
            HtmlNode desc = htmlDoc.DocumentNode.SelectNodes("//div[@class='movie-synopsis right']").First();

            Console.WriteLine(title.InnerHtml.Trim());
            foreach (var item in jenisFilm)
            {

                Console.WriteLine(item.InnerText.Trim().Replace("\t", string.Empty));
            }
            Console.WriteLine($"Synopsis: {desc.InnerText.Trim()}");
        }
    }

    class Articles
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
