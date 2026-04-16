using System.Web;
using System.Web.Optimization;

namespace SelectionDemo
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Content/css").Include(
                                "~/Content/Selections.css",
                                "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                            "~/Scripts/selections.js"));
        }
    }
}
