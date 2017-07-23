using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using System;
using WebApplicationNew.Models;

namespace WebApplicationNew.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // поиск пользователя в бд
                User user = null;
                WTLs wtl = null;
                using (UserContext db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == model.Name && u.Password == model.Password);
                    wtl = db.WTLs.Add(new WTLs
                    {
                        Name = db.Users.FirstOrDefault(u => u.Email == model.Name && u.Password == model.Password).Email.ToString(),
                        Monday = DateTime.Now,
                        Tuesday = DateTime.Now,
                        Wednesday = DateTime.Now,
                        Thursday = DateTime.Now,
                        Friday = DateTime.Now,
                        Saturday = DateTime.Now,
                        Sunday = DateTime.Now
                    });
                    db.SaveChanges();
                }
                if (user != null)
                {
                    
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }

            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                using (UserContext db = new UserContext())
                {
                    user = db.Users.FirstOrDefault(u => u.Email == model.Name);
                }
                if (user == null)
                {
                    // создаем нового пользователя
                    using (UserContext db = new UserContext())
                    {
                        db.Users.Add(new User { Email = model.Name, Password = model.Password, Age = model.Age, start_time = DateTime.Now});
                        db.SaveChanges();
                        
                        user = db.Users.Where(u => u.Email == model.Name && u.Password == model.Password).FirstOrDefault();
                    }
                    // если пользователь удачно добавлен в бд
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(model);
        }
        public ActionResult Logoff(LoginModel model)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}