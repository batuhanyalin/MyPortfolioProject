﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutSideBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
