using System.Web;
using System.Web.Optimization;

namespace RealStateAgency
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Content/assets/vendor/bootstrap/js/bootstrap.js",
                      "~/Content/assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/assets/vendor/php-email-form/validate.js",
                      "~/Content/assets/vendor/aos/aos.js",
                      "~/Content/assets/vendor/swiper/swiper-bundle.min.js",
                      "~/Content/assets/vendor/purecounter/purecounter_vanilla.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/assets/vendor/bootstrap/css/bootstrap.css",
                        "~/Content/Site.css",
                        "~/Content/assets/vendor/bootstrap/css/bootstrap.min.css",
                        "~/Content/assets/vendor/bootstrap-icons/bootstrap-icons.css",
                        "~/Content/assets/vendor/vendor/aos/aos.css",
                        "~/Content/assets/vendor/fontawesome-free/css/all.min.css",
                        "~/Content/assets/vendor/swiper/swiper-bundle.min.css"
                      ));
        }
    }
}
