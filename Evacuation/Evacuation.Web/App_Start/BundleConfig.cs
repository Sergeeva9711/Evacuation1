using System.Web;
using System.Web.Optimization;

namespace Evacuation.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
           // bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
           //             "~/Scripts/neon/jquery-{version}.js"));

           // bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
           //             "~/Scripts/jquery.validate*"));

           // // Use the development version of Modernizr to develop with and learn from. Then, when you're
           // // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
           // bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
           //             "~/Scripts/modernizr-*"));

           // bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
           //           "~/Scripts/neon/bootstrap.js",
           //           "~/Scripts/respond.js"));

           // bundles.Add(new ScriptBundle("~/bundles/myscript").Include(
           //     "~/Scripts/neon/main-gsap.js", "~/Scripts/neon/jquery-ui-1.10.3.minimal.min.js",
           //     "~/Scripts/neon/joinable.js", "~/Scripts/neon/resizeable.js",
           //     "~/Scripts/neon/neon-api.js", "~/Scripts/neon/neon-custom.js",
           //     "~/Scripts/neon/neon-demo.js"));


           //bundles.Add(new StyleBundle("~/Content/css").Include(
           //           "~/Content/neon/jquery-ui-1.10.3.custom.min.css",
           //           "~/Content/neon/entypo.css",
           //           "~/Content/neon/bootstrap.css", "~/Content/neon/neon-core.css",
           //           "~/Content/neon/neon-theme.css", "~/Content/neon/neon-forms.css",
           //           "~/Content/neon/custom.css", "~/Content/neon/black.css",
           //           "~/Content/site.css"));


            var bundle = new StyleBundle("~/assets/js/jquery-ui/css/no-theme/virtual.css");
            bundle.Include("~/assets/js/jquery-ui/css/no-theme/jquery-ui-1.10.3.custom.css",
                 "~/assets/js/jquery-ui/css/no-theme/jquery.ui.theme.css");
            bundles.Add(bundle);

            bundle = new StyleBundle("~/assets/css/font-icons/entypo/css/virtual.css");
            bundle.Include("~/assets/css/font-icons/entypo/css/entypo.css");
            bundles.Add(bundle);

            bundle = new StyleBundle("~/assets/css/font-icons/font-awesome/css/virtual.css");
            bundle.Include("~/assets/css/font-icons/font-awesome/css/font-awesome.css");
            bundles.Add(bundle);

            bundle = new StyleBundle("~/assets/css/virtual.css");
            bundle.Include(
                "~/assets/css/bootstrap.css",
                "~/assets/css/neon-core.css",
                "~/assets/css/neon-theme.css",
                "~/assets/css/neon-forms.css",
                "~/assets/css/custom.css",
                "~/assets/js/select2/select2.css",
                "~/assets/js/vertical-timeline/css/component.css"
            );
            bundles.Add(bundle);

            var bundle1 = new ScriptBundle("~/assests/js/virtual.js");
            bundle1.Include(
                "~/assets/js/neon-custom.js",
                "~/assests/js/jquery-1.11.0.min.js"                
                );
            bundles.Add(bundle1);

            //bundle1 = new ScriptBundle("~/assets/js/gsap/virtual.js");
            //bundle1.Include("~/assets/js/gsap/main-gsap.js");
            //bundles.Add(bundle1);            

            //< script src = "assets/js/jquery-ui/js/jquery-ui-1.10.3.minimal.min.js" ></ script >  

            //< script src = "assets/js/jvectormap/jquery-jvectormap-1.2.2.min.js" ></ script >       
            //< script src = "assets/js/jvectormap/jquery-jvectormap-europe-merc-en.js" ></ script >        
            //< script src = "assets/js/jquery.sparkline.min.js" ></ script >         
            //< script src = "assets/js/rickshaw/vendor/d3.v3.js" ></ script >          
            //< script src = "assets/js/rickshaw/rickshaw.min.js" ></ script >           


            //"~/assests/js/neon-custom.js",
            //,
            //"~/assets/js/bootstrap.js",
            //"~/assets/js/joinable.js",
            //"~/assets/js/resizeable.js",
            //"~/assets/js/neon-api.js",
            //"~/assets/js/jquery.sparkline.min.js",
            //"~/assets/js/raphael-min.js",
            //"~/assets/js/morris.min.js",
            //"~/assets/js/toastr.js",
            //"~/assets/js/neon-custom.js",
            //"~/assets/js/neon-demo.js"                


        }
    }
}
