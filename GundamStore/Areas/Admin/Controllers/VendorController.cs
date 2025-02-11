using Microsoft.AspNetCore.Mvc;

namespace GundamStore.Areas.admin.Controllers
{
    [Area("Admin")]
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
