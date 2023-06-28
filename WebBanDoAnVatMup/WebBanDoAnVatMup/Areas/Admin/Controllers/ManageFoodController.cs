using System;
using System.Collections.Generic;
using System.IO;
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
        [HttpGet]
        public ActionResult index()
        {
            if (Session["Admin"] == null)
            {
                return RedirectToAction("index", "LoginAdmin");
            }
            var products = db.products.ToList();
            return View(products);          
        }

        [HttpGet]
        public ActionResult add_food()
        {
            return View();
        }

        [HttpPost]
        public ActionResult add_food(product product_model, HttpPostedFileBase image_file)
        {
            string file_name = Path.GetFileNameWithoutExtension(image_file.FileName);
            string extension = Path.GetExtension(image_file.FileName);
            file_name = file_name + DateTime.Now.ToString("yymmssfff") + extension;
            product_model.image = "~/Assets/Admin/images/products/" + file_name;
            file_name = Path.Combine(Server.MapPath("~/Assets/Admin/images/products/"), file_name);
            image_file.SaveAs(file_name);
            db.products.Add(product_model);
            db.SaveChanges();
            ModelState.Clear();
            return View();
        }
    }
}