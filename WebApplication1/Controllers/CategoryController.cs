using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CategoryController : Controller
    {
        P112NewsEntities db = new P112NewsEntities();
        // GET: Category
        public ActionResult List()
        {
            List<Category> kateqoriyalar = db.Categories.ToList();
            return View(kateqoriyalar);
        }
        public ActionResult Details(int id)
        {
            Category cat = db.Categories.FirstOrDefault(c => c.Id == id);
            return View(cat);
        }
    }
}