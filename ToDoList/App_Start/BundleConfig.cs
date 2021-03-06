﻿using System.Web.Optimization;

namespace ToDoList
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js",
                "~/Scripts/knockout-3.4.2.js",
                "~/Scripts/knockout.mapping.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/ToDoListViewModel.js",
                "~/Scripts/app/ListViewModel.js",
                "~/Scripts/app/ListItemViewModel.js",
                "~/Scripts/app/services/ListItemsService.js",
                "~/Scripts/app/services/ListsService.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
