using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SitecorePoweredBlog.Models;
using SitecorePoweredBlog.DAL;

namespace SitecorePoweredBlog.Controllers
{
    public class HomeController : Controller
    {
        private SitecoreDBContext db = new SitecoreDBContext();
        // GET: Home
        public ActionResult Index(int? id)
        {
            if (!(id.HasValue)) // if ''id'' does not have value (is null)
            {
                id = 1; // set value for ''id'' to 1 by default
            }

            if (TempData["BlogTitle"] != null)
            {
                string blogtitle = (string)TempData["BlogTitle"];
                ViewBag.BlogTitle = blogtitle;
                int blogsno = db.Blogs
                                .Where(b => b.Title.Contains(blogtitle))
                                .Count();
                ViewBag.TotalBlogs = blogsno;
                ViewBag.PageID = id;

                return View(db.Blogs.Where(b => b.Title.Contains(blogtitle)).ToList().Skip(((int)id - 1) * 2).Take(2));
            }
            else
            {
                int blogsno = db.Blogs.Count();
                ViewBag.TotalBlogs = blogsno;
                ViewBag.PageID = id;

                return View(db.Blogs.ToList().Skip(((int)id - 1) * 2).Take(2));
            }       
        }

        [HttpGet]
        public ActionResult Search(string blogtitle)
        {
            TempData["BlogTitle"] = blogtitle;
            return RedirectToAction("Index");
        }
    }
}