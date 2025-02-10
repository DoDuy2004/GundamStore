using GundamStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Giỏ hàng", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }
    }
}
