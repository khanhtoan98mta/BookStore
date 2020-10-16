using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookShop.Models.Function;

namespace BookShop.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var model = new F_Book().DSSach.ToList();
            ViewBag.Book = model; 
            return View(model);
        }

        public ActionResult Hello()
        {
            string str = "";
            str = "toan";
            return View() ;
        }
        public ActionResult BookDetail(long id)
        {
            var model = new F_Book().FindEntity(id);
            ViewBag.Sach = model;
            return View(model);
        }


    }
}