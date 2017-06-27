using Scraping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DataController data = new DataController();
            var articles = data.GetArticles();
            foreach(Article a in articles)
            {
                Console.WriteLine($"{a.Title}\n {a.Url}\n {a.ImageUrl}");
            }
            Console.ReadKey(true);

        }
    }
}
