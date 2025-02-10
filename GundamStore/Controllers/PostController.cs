using GundamStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Tin tức", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }

        public IActionResult Details()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Tin tức", Url = Url.Action("Index", "Post") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Tên bài viết", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }
    }
}
