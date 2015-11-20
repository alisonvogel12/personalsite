using System.Web.Mvc;

namespace AlisonVogel.Web.Controllers
{
    public class ResumeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Resume";
            return View();
        }

        public FileResult ViewResume()
        {
            return File("~/Files/AlisonVogelResume.PDF", "application/pdf");
        }
	}
}