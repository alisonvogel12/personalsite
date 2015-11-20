using System.Web.Mvc;

namespace AlisonVogel.Web.HtmlHelpers
{
    public static class HtmlHelperExt
    {
        public static string ActivePage(this HtmlHelper helper, string controller)
        {
            string classValue = "";

            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();

            if (currentController == controller)
            {
                classValue = "selecteditem";
            }

            return classValue;
        }
    }
}