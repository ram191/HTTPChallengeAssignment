using AsyncAwaitProject.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public static List<string> ParseAllLinks()
        {
            string html = @"https://www.cgv.id/en/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            HtmlNode[] films = htmlDoc.DocumentNode.SelectNodes("//ul[@class='slides']//li//a").ToArray();
            var links = new List<string>();

            foreach(var item in films)
            {
                links.Add((item.Attributes["href"].Value)); 
            }
            return links;
        }

        public static void ParseAll()
        {
            var links = ParseAllLinks();
            foreach(var link in links)
            {
                string html = link;

                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load(html);

                string title = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='movie-info-title']").InnerText.Trim();
                string info = htmlDoc.DocumentNode.SelectSingleNode(@"/html/body/div[2]/div/div[2]/div/div[1]/div[2]/div[2]/div[1]/ul").InnerText;
                string synopsis = htmlDoc.DocumentNode.SelectSingleNode(@"/html/body/div[2]/div/div[2]/div/div[1]/div[2]/div[2]/div[2]").InnerText;

                Console.WriteLine($"JUDUL: {title}");
                Console.WriteLine((info).Replace("\t", string.Empty).Trim());
                Console.WriteLine($"SYNOPSIS: {(synopsis).Replace("\t", string.Empty).Replace("\n", string.Empty).Trim()}\n");
            }
        }
    }
}
