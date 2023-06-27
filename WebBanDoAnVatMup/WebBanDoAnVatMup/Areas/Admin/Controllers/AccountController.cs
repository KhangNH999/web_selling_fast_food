using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using WebBanDoAnVatMup.Models;

namespace WebBanDoAnVatMup.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(account_user model)
        {
            //var result = new account_bll().login_admin(model.user_name, model.password);
            if(Membership.ValidateUser(model.user_name,model.password) && ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.user_name, true);
                return RedirectToAction("Index", "Layout");
            }
            else
            {          
                ModelState.AddModelError("","Tên đăng nhập hoặc mật khẩu không đúng.");
            }
            return View(model);
        }
    }
}