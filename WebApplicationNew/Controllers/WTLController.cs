using System;
using System.Web.Mvc;
using WebApplicationNew.Models;

namespace WebApplicationNew.Controllers
{
    public class WTLController : Controller
    {

        User user;
        // GET: WTL
        public ActionResult Index()
        {
            var date = new WTL { EndDate = DateTime.Now };
            return View(date);
        }
    }
}