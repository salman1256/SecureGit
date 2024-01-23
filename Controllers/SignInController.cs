using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSecure.Models;

namespace WebAppSecure.Controllers
{
    public class SignInController : Controller
    {
        // GET: SignIn
        [HttpGet]
        public ActionResult Index()
        {
            return View(new SignIn());
        }
        [HttpPost]
        public ActionResult Index(SignIn sign)
        {
            if (ModelState.IsValid)
            {
                if ((sign.UserName == "sam1256") && (sign.Password == "sam@1256@1256"))
                {

                    Session["UserId"] = Guid.NewGuid();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Either User Name or Password Incorrect!!!");
                    return View(sign);

                }
            }
            else
            { return View(sign); }

        }
    }
}
   