using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.ValidationRules;
using MyPortfolioProject.DtoLayer.RegisterDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProject.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly IMapper _mapper;

        public RegisterController(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto registerDto)
        {
            var value = _mapper.Map<AppUser>(registerDto);
            var register = await _userManager.CreateAsync(value, registerDto.Password);
            if (register.Succeeded)
            {
                var user = await _userManager.FindByNameAsync(registerDto.UserName);
                var currentRoles = await _userManager.GetRolesAsync(user);
                await _userManager.RemoveFromRolesAsync(user, currentRoles);
                await _userManager.AddToRoleAsync(user, "Admin");
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in register.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
    }
}
