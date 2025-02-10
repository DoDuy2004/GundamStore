using GundamStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GundamStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult About()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Giới thiệu", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }

        public IActionResult Contact()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Liên hệ", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }
    }
}
