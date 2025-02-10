using GundamStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Tất cả sản phẩm", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }

        public IActionResult Details()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Tên danh mục cha", Url = Url.Action("Index", "Product", new { CategoryId = 1 }) ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Tên sản phẩm", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }

        public IActionResult Wishlist()
        {
            var breadcrumbs = new List<BreadcrumbItem>
            {
                new BreadcrumbItem { Title = "Trang chủ", Url = Url.Action("Index", "Home") ?? "/", IsActive = false },
                new BreadcrumbItem { Title = "Yêu thích", Url = "#", IsActive = true }
            };

            ViewData["Breadcrumbs"] = breadcrumbs;
            return View();
        }
    }
}
