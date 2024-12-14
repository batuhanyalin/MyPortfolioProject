using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
