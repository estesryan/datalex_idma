using System.Web.Mvc;

namespace Datalex.IDMA.Web.Controllers
{
    /// <summary>
    /// Represents the home controller
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}