using System.Web.Mvc;

namespace ServerSidePaging.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View(Views.ViewNames.Index);
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(Views.ViewNames.About);
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(Views.ViewNames.Contact);
        }
    }
}