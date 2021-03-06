﻿using System.Web;
using System.Web.Optimization;
using Web.Optimization.Bundles.Less;

namespace CorsoMaggioWeb.WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/appjs").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/addtohomescreen.min.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/addtohomescreen.css",
                      "~/Content/site.css"));




#if !DEBUG
            System.Web.Optimization.BundleTable.EnableOptimizations = true;
#endif

        }
    }
}
