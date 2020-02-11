using System;
using System.Threading.Tasks;

namespace AsyncAwaitProject
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //NumberOne
            //Fetcher.Get("www.kompas.com");
            //Applied in Number Two

            //NumberTwo
            Console.WriteLine(await NumberTwo.RichEmployees());
            Console.WriteLine(await NumberTwo.LivesInJakarta());
            Console.WriteLine(await NumberTwo.BornOnMarch());
            Console.WriteLine(await NumberTwo.RndEmployees());
            Console.WriteLine(await NumberTwo.TotalAbsences());

            //Number Three
            Console.WriteLine(await NumberThree.GetData());

            //Number Four
            Console.WriteLine(await MovieDbApi.GetIndonesian());
            Console.WriteLine(await MovieDbApi.GetKeanu());
            Console.WriteLine(await MovieDbApi.GetGood2016());
            Console.WriteLine(await MovieDbApi.GetRobertAndTom());

            //Number Five
            WebScrapes.ParseKompas();

            //Number Six
            WebScrapes.ParseAll();
        }
    }
}
