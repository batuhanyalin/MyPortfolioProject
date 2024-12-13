using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultNavBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
