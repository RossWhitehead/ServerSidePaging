using System.Web;
using System.Web.Optimization;

namespace Links
{
    public static partial class Bundles
    {
        public static partial class Scripts
        {
            public static readonly string jquery = "~/bundles/jquery";
            public static readonly string jqueryval = "~/bundles/jqueryval";
            public static readonly string modernizr = "~/bundles/modernizr";
            public static readonly string bootstrap = "~/bundles/bootstrap";
        }
        public static partial class Styles
        {
            public static readonly string content = "~/Content/css";
        }
    }
}

namespace ServerSidePaging
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.jquery).Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.jqueryval).Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.modernizr).Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.bootstrap).Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle(Links.Bundles.Styles.content).Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
