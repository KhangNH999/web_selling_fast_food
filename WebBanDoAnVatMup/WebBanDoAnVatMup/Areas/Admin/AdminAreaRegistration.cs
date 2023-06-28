using System.Web.Mvc;

namespace WebBanDoAnVatMup.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin",
                "Admin/{controller}/{action}/{id}",
                new {controller = "LoginAdmin", action = "index", id = UrlParameter.Optional }
            );
        }
    }
}