using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
