using System.Web.Optimization;

namespace AdminTec
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            #region JAVASCRIPT'S

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-3.1.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/respond.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-toolkit").Include(
                "~/Scripts/bootstrap-toolkit.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/dropzone").Include(
                "~/Scripts/dropzone.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/eventemitter2").Include(
                "~/Scripts/eventemitter2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jQuerySortable").Include(
                        "~/Scripts/jQuerySortable.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/metisMenu").Include(
                "~/Scripts/metisMenu.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/morris").Include(
                "~/Scripts/morris.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/mocha").Include(
                "~/Scripts/mocha.js"));

            bundles.Add(new ScriptBundle("~/bundles/raphael").Include(
                "~/Scripts/raphael.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/ResponsiveBootstrapToolkit").Include(
                "~/Scripts/ResponsiveBootstrapToolkit.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Sortable").Include(
                "~/Scripts/Sortable.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/TinyColor").Include(
                "~/Scripts/TinyColor.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/jquery.unobtrusive-ajax.min.js"
                ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.min.js"));

            #endregion JAVASCRIPT'S

            #region ESTILOS

            bundles.Add(new StyleBundle("~/Content/modernizr").Include(
                      "~/Content/modernizr.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-*.min.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/animate").Include(
                      "~/Content/animate.min.css"));

            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/QuillEditor").Include(
                      "~/Content/QuillEditor.css"));

            bundles.Add(new StyleBundle("~/Content/Site").Include(
                      "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/site").Include(
                      "~/Content/site.css"));

            #endregion ESTILOS
        }
    }
}