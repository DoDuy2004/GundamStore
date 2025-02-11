using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Areas.admin.Controllers
{
    [Area("admin")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public IActionResult ProductAdd()
        {
            return View();
        }
        public IActionResult ReviewList()
        {
            return View();
        }
    }
}
