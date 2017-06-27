using Scraping.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scraping.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Article> Articles { get; set; }
    }
}