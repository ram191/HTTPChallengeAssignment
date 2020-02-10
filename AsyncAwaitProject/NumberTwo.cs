using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AsyncAwaitProject
{
    public class NumberTwo
    {
        public static async Task<string> RichEmployees()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://mul14.github.io/data/employees.json");
            var jObj = JsonConvert.DeserializeObject<List<Employee>>(result);
            var names = new List<string>();

            foreach (var id in jObj)
            {
                var x = jObj
                    .Where(x => x.Salary < 15000000)
                    .Select(x => x.First_name);
                names = x.ToList();
            }
            return String.Join(',', names);
        }

        public static async Task<string> LivesInJakarta()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://mul14.github.io/data/employees.json");
            var jObj = JsonConvert.DeserializeObject<List<Employee>>(result);
            var names = new List<string>();

            foreach (var id in jObj)
            {
                var ad = id.Addresses;
                foreach (var add in ad)
                {
                    if (add.City.Contains("Jakarta"))
                    {
                        names.Add(id.First_name);
                    }
                }
            }
            var hasil = names.Distinct();
            return String.Join(',', hasil);
        }

        // Add if result is null
        public static async Task<string> BornOnMarch()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://mul14.github.io/data/employees.json");
            var jObj = JsonConvert.DeserializeObject<List<Employee>>(result);
            var names = new List<string>();

            foreach (var id in jObj)
            {
                foreach (var bday in jObj)
                {
                    //var convertedDay = bday.Birthday.ToShortDateString();
                    var month = bday.Birthday.Month;
                    if (month == 03)
                    {
                        names.Add(bday.First_name);
                    }
                }
            }
            var hasil = names.Distinct();
            return String.Join(',', hasil);
        }


        //Juan????
        public static async Task<string> RndEmployees()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://mul14.github.io/data/employees.json");
            var jObj = JsonConvert.DeserializeObject<List<Employee>>(result);
            var names = new List<string>();

            foreach (var id in jObj)
            {
                foreach (var x in jObj)
                {
                    var dept = x.Department.Name;
                    if (dept == "Research and development")
                    {
                        names.Add(id.First_name);
                    }
                }
            }
            var hasil = names.Distinct();
            return String.Join(',', hasil);
        }

        public static async Task<string> TotalAbsences()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://mul14.github.io/data/employees.json");
            var jObj = JsonConvert.DeserializeObject<List<Employee>>(result);
            var names = new List<int>();

            foreach (var id in jObj)
            {
                var oct = id.Presence_list
                    .Where(x => x.Month == 10)
                    .Count();
                names.Add(oct);
            }
            var count = names.Sum();
            return $"The amount of the total employees' attendance in October is {count}";
        }
    }
}
