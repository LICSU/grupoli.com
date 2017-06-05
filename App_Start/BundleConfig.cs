using System.Web.Optimization;

namespace GrupoLi
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.
                Add(new ScriptBundle("~/bundles/jquery").
                Include("~/Scripts/jquery-{version}.js"));

            bundles.
                Add(new ScriptBundle("~/bundles/jqueryval").
                Include("~/Scripts/jquery.validate*"));

            bundles.
                Add(new ScriptBundle("~/bundles/modernizr").
                Include("~/Scripts/modernizr-*"));

            bundles.
                Add(new ScriptBundle("~/bundles/bootstrap").
                Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"
                    ));
            bundles.
                Add(new ScriptBundle("~/bundles/template").
                Include(
                    "~/Scripts/html5shiv.js",
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/jquery.countTo.js",
                    "~/Scripts/jquery.inview.min.js",
                    "~/Scripts/jquery.js",
                    "~/Scripts/lightbox.min.js",
                    "~/Scripts/main.js",
                    "~/Scripts/mousescroll.js",
                    "~/Scripts/respond.min.js",
                    "~/Scripts/smoothscroll.js",
                    "~/Scripts/wow.min.js"
                    ));

            bundles.
                Add(new StyleBundle("~/Content/css").
                Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/animate.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/lightbox.css",
                      "~/Content/main.css",
                      "~/Content/responsive.css",
                      "~/Content/presets/preset1.css",
                      "~/Content/presets/preset2.css",
                      "~/Content/presets/preset3.css",
                      "~/Content/presets/preset4.css",
                      "~/Content/presets/preset5.css",
                      "~/Content/presets/preset6.css",
                      "~/Content/site.css")
                      );
        }
    }
}
