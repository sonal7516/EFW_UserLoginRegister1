using EFW_UserLoginRegister1.DbModel;
using EFW_UserLoginRegister1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFW_UserLoginRegister1.Controllers
{
    public class AccountController : Controller
    {
        UserDbEntities dbContext = new UserDbEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            UserModel userModel = new UserModel();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult Register(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                if (!dbContext.Users.Any(e=>e.Email==userModel.Email))
                {
                    User user = new User();
                    user.FirstName = userModel.FirstName;
                    user.LastName = userModel.LastName;
                    user.Email = userModel.Email;
                    user.Password = userModel.Password;
                    user.Created_On = DateTime.Now;
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "Email is already exist!!");
                }
                
            }
            
            return View();
        }
        public ActionResult Login()
        {
            Login login = new Login();
            return View(login);
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                if(dbContext.Users.Where(e=>e.Email==login.Email && e.Password == login.Password)==null)
                {
                    ModelState.AddModelError("Error", "Email or Password is not Valid!!");
                    return View();
                }
                else
                {
                    Session["Email"] = login.Email;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}