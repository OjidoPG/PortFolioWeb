using System.Web;
using System.Web.Optimization;

namespace SitePersoWeb
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include("~/vendor/bootstrap/css/bootstrap.min.css", "~/vendor/fontawesome-free/css/all.min.css", "~/css/resume.min.css", 
                "~/css/regExp.css"));
        }
    }
}
