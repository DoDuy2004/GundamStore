using GundamStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Tài khoản của tôi", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }

        public IActionResult Login()
        { 
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
