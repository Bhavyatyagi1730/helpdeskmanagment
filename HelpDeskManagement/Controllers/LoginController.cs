using Service.Class;
using Service.Entities;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpDeskManagement.Controllers
{
    public class LoginController : Controller
    {

        ILogin _login = null;
        public LoginController()
        {
            _login = new Login();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid == true)
            {
                User obj = new User();
                obj = _login.GetinfoByUserCredentials(user.UserName, user.Password);
                if (obj == null)
                {
                    ViewBag.ErrorMessage = "Login Failed!";
                    return View();
                }


                else
                {
                    Session["username"] = user.UserName;
                    //Session["password"]=s.password;
                    return RedirectToAction("Index", "Dashboard");
                }
            }
            return View();
        }
    }
}