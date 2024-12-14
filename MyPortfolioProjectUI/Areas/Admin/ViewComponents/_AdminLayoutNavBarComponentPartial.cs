using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutNavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
