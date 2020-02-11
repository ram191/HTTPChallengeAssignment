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

            foreach (HtmlNode item in hnodes)
            {
                Console.WriteLine(item.InnerHtml);
            }

            foreach (HtmlNode item in unodes)
            {
                Console.WriteLine(item.Attributes["href"].Value);
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
}
