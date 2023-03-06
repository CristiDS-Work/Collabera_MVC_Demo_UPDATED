using SitecorePoweredBlog.Models;
using SitecorePoweredBlog.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecorePoweredBlog.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index(int? id)
        {
            if(!(id.HasValue)) // if ''id'' does not have value (is null)
            {
                id = 1; // set value for ''id'' to 1 by default
            }

            using (var db = new SitecoreDBContext())
            {
                var bloginfo = db.Blogs
                                .Where(b => b.BlogId == id)
                                .FirstOrDefault<Blog>();
                return View(bloginfo);
            }
        }
    }
}