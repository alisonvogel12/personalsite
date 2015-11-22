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
                BundleTable.EnableOptimizations = true;
            }
        }

    }
}