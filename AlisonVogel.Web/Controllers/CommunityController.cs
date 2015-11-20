using System.Web.Mvc;

namespace AlisonVogel.Web.Controllers
{
    public class CommunityController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Community";
            return View();
        }

	}
}