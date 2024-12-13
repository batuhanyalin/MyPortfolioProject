using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultMySkillsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
