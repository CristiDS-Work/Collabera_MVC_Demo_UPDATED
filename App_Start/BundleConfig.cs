using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace SitecorePoweredBlog
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css/bootstrap").Include(
                        "~/Content/css/bootstrap-themed.min.css")
                        );

            bundles.Add(new StyleBundle("~/Content/css/custom").Include(
                        "~/Content/css/blogsite.css")
                        );

            bundles.Add(new ScriptBundle("~/Scripts/default").Include(
                        "~/Scripts/modernizr-2.8.3.js")
                        );

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap.min.js")
                        );

            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                        "~/Scripts/jquery-3.3.1.slim.min.js")
                        );
        }
    }
}