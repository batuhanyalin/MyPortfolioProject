using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.DtoLayer.IdentityDtos;
using MyPortfolioProject.EntityLayer.Concrete;
using MyPortfolioProjectUI.Areas.Admin.Models;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public ProfileController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        [Route("Index")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (User.Identity.Name==null)
            {
                return View();
            }
            else
            {
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                ProfileUpdateModel model = new ProfileUpdateModel();
                model.Email = values.Email;
                model.Username = values.UserName;
                model.Name = values.Name;
                model.Surname = values.Surname;
                return View(model);
            }
    
        }
        [Route("Index")]
        [HttpPost]
        public async Task<IActionResult> Index(ProfileUpdateModel model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Email = model.Email;
            user.Name = model.Name;
            user.Surname = model.Surname;

            if (model.Password != null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            }
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default", new { area = "Admin" });
            }
            else
            {
                return View(model);
            }

        }
    }
}
