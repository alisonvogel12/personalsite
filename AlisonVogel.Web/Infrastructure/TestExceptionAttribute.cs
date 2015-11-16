using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlisonVogel.Web.Infrastructure
{
    public class TestExceptionAttribute : FilterAttribute, IExceptionFilter
    {

        public void OnException(ExceptionContext filterContext)
        {

            if (!filterContext.ExceptionHandled &&
                    filterContext.Exception is ArgumentOutOfRangeException)
            {

                filterContext.Result = new ViewResult
                {
                    ViewName = "ErrorPage",
                };
                // filterContext.Result = new RedirectResult("~/Content/RangeErrorPage.html");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}
