using System.Web.Mvc;

namespace OnlineShop.Areas.Admin
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
                "Admin_default",
                //Đường dẫn vào trang của Admin
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", controller="Home", id = UrlParameter.Optional },
                new string[] { "OnlineShop.Areas.Admin.Controllers" }
            );
        }
    }
}