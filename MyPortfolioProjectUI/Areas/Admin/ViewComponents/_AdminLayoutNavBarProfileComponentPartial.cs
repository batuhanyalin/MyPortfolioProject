using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutNavBarProfileComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminLayoutNavBarProfileComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (User.Identity.Name == null)
            {
                return View();
            }
            else
            {
                var value = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.user = value.Name + " " + value.Surname;
                return View();
            }

        }
    }
}
