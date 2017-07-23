using WebApplicationNew.Models;
using System.Web.Mvc;

namespace WebApplicationNew.Controllers
{
    public class WTLController : Controller
    {
        UserContext db = new UserContext();
        // GET: WTL
        public ActionResult Index()
        {

            return View(db.WTLs);
        }
    }
}