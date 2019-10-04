using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NewsController : Controller
    {

        P112NewsEntities db = new P112NewsEntities();

        // GET: News
        public ActionResult Index()
        {
            List<News> news = db.News.ToList();
            return View(news);
        }

        public ActionResult Xeber(int? xeberinIDsi)
        {
           News xeber =  db.News.FirstOrDefault(n => n.Id == xeberinIDsi);
            return View(xeber);
        }
    }
}