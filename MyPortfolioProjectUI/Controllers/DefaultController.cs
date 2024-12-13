using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
