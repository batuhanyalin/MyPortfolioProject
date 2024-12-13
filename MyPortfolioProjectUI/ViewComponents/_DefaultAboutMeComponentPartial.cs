using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultAboutMeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
