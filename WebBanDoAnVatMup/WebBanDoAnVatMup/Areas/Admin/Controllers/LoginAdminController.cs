using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebBanDoAnVatMup.Models;

namespace WebBanDoAnVatMup.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: Admin/Login
        banDoAnVatMup_DB db = new banDoAnVatMup_DB();
        [HttpGet]
        public ActionResult index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult index(account_user model)
        {
            var user_name = model.user_name;
            var password = model.password;
            var user_check = db.account_user.SingleOrDefault(x => x.user_name.Equals(user_name) && x.password.Equals(password));
            if (user_check != null && ModelState.IsValid)
            {
                Session["Admin"] = user_check;
                return RedirectToAction("Index", "ManageFood");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng.");
                return View(model);
            }

        }

        [HttpGet]
        public ActionResult logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "LoginAdmin");
        }
    }
}