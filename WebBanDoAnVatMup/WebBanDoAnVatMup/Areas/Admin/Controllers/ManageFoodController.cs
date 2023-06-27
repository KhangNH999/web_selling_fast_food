using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDoAnVatMup.Models;

namespace WebBanDoAnVatMup.Areas.Admin.Controllers
{
 
    public class ManageFoodController : Controller
    {
        // GET: Admin/ManageFood
        private banDoAnVatMup_DB db = new banDoAnVatMup_DB();
        public ActionResult Index()
        {
            if (Session["Admin"] == null)
            {
                return RedirectToAction("Index", "LoginAdmin");
            }
            var products = db.products.ToList();
            return View(products);
        }
    }
}