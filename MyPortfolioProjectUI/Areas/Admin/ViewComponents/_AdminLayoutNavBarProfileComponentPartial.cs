using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutNavBarProfileComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
