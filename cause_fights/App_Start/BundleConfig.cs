using System.Web;
using System.Web.Optimization;

namespace cause_fights
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/js/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Scripts/scroll").Include(
                      "~/Scripts/js/scroll.js"));

            bundles.Add(new ScriptBundle("~/Scripts/responsive").Include("~/Scripts/js/responsiveslides.js"));
            bundles.Add(new ScriptBundle("~/Scripts/smooth").Include("~/Scripts/js/SmoothScroll.js"));
            bundles.Add(new ScriptBundle("~/Scripts/easing").Include("~/Scripts/js/easing.js"));
            bundles.Add(new ScriptBundle("~/Scripts/jar").Include("~/Scripts/js/jarallax.js"));
            bundles.Add(new ScriptBundle("~/Scripts/move").Include("~/Scripts/js/move-top.js"));
            bundles.Add(new ScriptBundle("~/Scripts/bars").Include("~/Scripts/js/bar.js"));
            bundles.Add(new ScriptBundle("~/Scripts/custom").Include("~/Scripts/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/css/bootstrap.css",
                     "~/Content/css/site.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/css/font-awesome.css"));

        }
    }
}
