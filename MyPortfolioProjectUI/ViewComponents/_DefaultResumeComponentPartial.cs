using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultResumeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
