﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioProjectUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
