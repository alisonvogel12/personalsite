using System.Web.Mvc;

namespace AlisonVogel.Web.HtmlHelpers
{
    public static class HtmlHelperClass
    {
        public static string ActiveMenuItem(this HtmlHelper helper, string menuItem)
        {
            string classValue = "";

            string clickedMenuItem = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();

            if (menuItem == clickedMenuItem)
            {
                classValue = "selecteditem";
            }

            return classValue;
        }
    }
}