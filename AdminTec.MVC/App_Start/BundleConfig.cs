using System.Web.Optimization;

namespace AdminTec
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region JAVASCRIPT'S

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/vendor").Include(
                "~/Scripts/vendor.min.js"));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.min.js"));

            #endregion JAVASCRIPT'S

            #region ESTILOS

            bundles.Add(new StyleBundle("~/Content/app").Include(
                      "~/Content/app.min.css"));

            bundles.Add(new StyleBundle("~/Content/vendor").Include(
                      "~/Content/vendor.min.css"));

            bundles.Add(new StyleBundle("~/Content/app-blue").Include(
                      "~/Content/app-blue.min.css"));

            bundles.Add(new StyleBundle("~/Content/app-custom").Include(
                      "~/Content/app-custom.min.css"));

            bundles.Add(new StyleBundle("~/Content/app-green").Include(
                      "~/Content/app-green.min.css"));

            bundles.Add(new StyleBundle("~/Content/app-orange").Include(
                      "~/Content/app-orange.min.css"));

            bundles.Add(new StyleBundle("~/Content/app-purple").Include(
                      "~/Content/app-purple.min.css"));

            bundles.Add(new StyleBundle("~/Content/app-red").Include(
                      "~/Content/app-red.min.css"));

            bundles.Add(new StyleBundle("~/Content/app-seagreen").Include(
                      "~/Content/app-seagreen.min.css"));

            bundles.Add(new StyleBundle("~/Content/Site").Include(
                      "~/Content/Site.css"));

            #endregion ESTILOS
        }
    }
}