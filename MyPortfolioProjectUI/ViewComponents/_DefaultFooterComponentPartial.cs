using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
