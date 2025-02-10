using GundamStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Controllers
{
    public class OrderController : Controller
    {
        [Route("Checkout")]
        public IActionResult Index()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Thanh toán", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }
    }
}
