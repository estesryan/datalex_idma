using System.Web.Mvc;

namespace Datalex.IDMA.Web.Controllers
{
    /// <summary>
    /// Represents the info controller
    /// </summary>
    public class InfoController : Controller
    {
        public ActionResult About()
        {
            return View();
        }
    }
}