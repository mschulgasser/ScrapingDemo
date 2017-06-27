using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Scraping.Data
{
    public class DataController
    {
        public IEnumerable<Article> GetArticles()
        {
            using (var client = new WebClient())
            {

                client.Headers["User-Agent"] = "HELLO!!";
                string html = client.DownloadString("http://www.thelakewoodscoop.com/");
                var parser = new HtmlParser();
                var document = parser.Parse(html);
                var posts = document.QuerySelectorAll("div.post");
                List<Article> result = new List<Article>();
                foreach (var post in posts)
                {
                    Article a = new Article();
                    a.Title = post.QuerySelector("h2").QuerySelector("a").TextContent;
                    a.Url = post.QuerySelector("h2").QuerySelector("a").GetAttribute("href");
                    var img = post.QuerySelector("img");
                    if(img != null)
                    {
                        a.ImageUrl = img.GetAttribute("src");
                    }
                    result.Add(a);
                    a.Content = post.QuerySelector("p").TextContent;
                }
                return result;
            }
        }
    }
}
