using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
