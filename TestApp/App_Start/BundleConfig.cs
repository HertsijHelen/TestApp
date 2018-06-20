using System.Web.Optimization;

namespace TestApp
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/libraries/angular.js",
                        "~/Scripts/libraries/angular-animate.js",
                        "~/Scripts/libraries/angular-sanitize.js",
                        "~/Scripts/libraries/ui-bootstrap-tpls-2.5.0.js"));

            bundles.Add(new ScriptBundle("~/bundles/myScripts").Include(
                       "~/Scripts/angular.js",
                       "~/Scripts/factory.js",
                       "~/Scripts/controller.js",
                       "~/Scripts/filter.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css"));
        }
    }
}
