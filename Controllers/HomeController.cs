using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TekAdminLTE.Models;

namespace TekAdminLTE.Controllers
{
    public class HomeController : Controller
    {

        public List<NavItem> navItems = new List<NavItem>
        {
            new NavItem { Name = "Home", Action = "Index", Controller = "Home" },
            new NavItem { Name = "Contact", Action = "FeedBack", Controller = "Home" },
        };
        public ActionResult Index()
        {
            return View(navItems);
        }

        public ActionResult FeedBack()
        {
            return View(navItems);
        }  
    }
}