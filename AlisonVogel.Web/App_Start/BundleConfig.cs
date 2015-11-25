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
                StyleBundle siteCSS = new StyleBundle("~/Content/siteCSS");
                siteCSS.Include("~/Content/navbar_style.css",
                  "~/Content/site_style.css");
                bundles.Add(siteCSS);

                ScriptBundle siteJS = new ScriptBundle("~/Scripts/siteJS");
                siteJS.Include("~/Scripts/jquery-2.1.4.min.js", "~/Scripts/bootstrap.min.js");
                bundles.Add(siteJS);

                BundleTable.EnableOptimizations = true;
            }
        }

    }
}