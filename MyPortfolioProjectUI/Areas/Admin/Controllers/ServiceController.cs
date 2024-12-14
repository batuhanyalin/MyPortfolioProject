using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ServiceController : Controller
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
