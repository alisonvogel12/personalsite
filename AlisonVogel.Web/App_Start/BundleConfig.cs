using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace AlisonVogel.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            {
                bundles.UseCdn = true;

                StyleBundle siteCSS = new StyleBundle("~/Content/siteCSS");
                siteCSS.Include("~/Content/navbar_style.css",
                  "~/Content/site_style.css");
                bundles.Add(siteCSS);

                StyleBundle bootstrapCSS = new StyleBundle("~/Content/bootstrapCSS", "//maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css");
                bootstrapCSS.Include("~/Content/bootstrap.min.css");
                bundles.Add(bootstrapCSS);

                StyleBundle fontawesomeCSS = new StyleBundle("~/Content/fontawesomeCSS", "//maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css");
                fontawesomeCSS.Include("~/Content/font-awesome.css");
                bundles.Add(fontawesomeCSS);

                ScriptBundle siteJS = new ScriptBundle("~/Scripts/siteJS");
                siteJS.Include("~/Scripts/jquery-2.1.4.min.js", "~/Scripts/bootstrap.min.js");
                bundles.Add(siteJS);

                BundleTable.EnableOptimizations = true;
            }
        }

    }
}