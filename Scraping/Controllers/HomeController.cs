using Scraping.Data;
using Scraping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scraping.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = new DataController();
            var vm = new IndexViewModel();
            vm.Articles = controller.GetArticles();
            return View(vm);
        }

       
    }
}