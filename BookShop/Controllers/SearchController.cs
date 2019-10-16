using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.Models.Function;

namespace BookShop.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            var model = new F_Book().DSSach.ToList();
            ViewBag.Book = model;
            return View(model);
        }
        public ActionResult Chitiet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string txt)
        {
            var model = new F_Book().DSSach.Where(x => x.Name.Contains(txt)).ToList();
            ViewBag.Book = model;
            return View("Index", model);
        }

    }
}