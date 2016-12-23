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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker").Include(
                "~/Scripts/bootstrap-datepicker.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap3-wysihtml5").Include(
                "~/Scripts/bootstrap3-wysihtml5.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Chart").Include(
                "~/Scripts/Chart.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/daterangepicker").Include(
                "~/Scripts/daterangepicker.js"));

            bundles.Add(new ScriptBundle("~/bundles/fastclick").Include(
                "~/Scripts/fastclick.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/icheck").Include(
                "~/Scripts/icheck.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-2.2.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-jvectormap").Include(
                "~/Scripts/jquery-jvectormap-1.2.2.min.js",
                "~/Scripts/jquery-jvectormap-world-mill-en.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-knob").Include(
                "~/Scripts/jquery.knob.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-slimscroll").Include(
                "~/Scripts/jquery.slimscroll.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-sparkline").Include(
                "~/Scripts/jquery.sparkline.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                "~/Scripts/moment.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/morris").Include(
                "~/Scripts/morris.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/raphael").Include(
                "~/Scripts/raphael.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.min.js"));

            #endregion JAVASCRIPT'S

            #region ESTILOS
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                      "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap3-wysihtml5").Include(
                      "~/Content/bootstrap3-wysihtml5.min.css"));
                      
            bundles.Add(new StyleBundle("~/Content/font-awesome").Include(
                      "~/Content/font-awesome.min.css"));
                      
            bundles.Add(new StyleBundle("~/Content/AdminLTE").Include(
                      "~/Content/AdminLTE.min.css"));
                      
            bundles.Add(new StyleBundle("~/Content/skins").Include(
                      "~/Content/skins/_all-skins.min.css"));
                      
            bundles.Add(new StyleBundle("~/Content/iCheck").Include(
                      "~/Content/iCheck/flat/blue.css"));
                      
            bundles.Add(new StyleBundle("~/Content/morris").Include(
                      "~/Content/morris.css"));
                      
            bundles.Add(new StyleBundle("~/Content/jquery-jvectormap").Include(
                      "~/Content/jquery-jvectormap-1.2.2.css"));

            bundles.Add(new StyleBundle("~/Content/datepicker3").Include(
                      "~/Content/datepicker3.min.css"));

            bundles.Add(new StyleBundle("~/Content/daterangepicker").Include(
                      "~/Content/daterangepicker.css"));

            bundles.Add(new StyleBundle("~/Content/daterangepicker").Include(
                      "~/Content/bootstrap3-wysihtml5.min.css"));

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