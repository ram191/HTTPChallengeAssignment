using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncAwaitProject
{
    public class NumberFour
    {
        public static void Parse()
        {
            string html = @"https://kompas.com/";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            HtmlAgilityPack.HtmlNode[] unodes = htmlDoc.DocumentNode.SelectNodes("//a[@class='headline__thumb__link']").ToArray();
            HtmlAgilityPack.HtmlNode[] hnodes = htmlDoc.DocumentNode.SelectNodes("//h2[@class='headline__thumb__title']").ToArray();

            foreach (HtmlAgilityPack.HtmlNode item in hnodes)
            {
                Console.WriteLine(item.InnerHtml);
            }

            foreach (HtmlAgilityPack.HtmlNode item in unodes)
            {
                Console.WriteLine(item.Attributes["href"].Value);
            }
        }
    }
}
