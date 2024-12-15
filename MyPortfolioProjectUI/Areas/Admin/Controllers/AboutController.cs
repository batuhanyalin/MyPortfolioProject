using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.AboutDtos;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var value = _aboutService.TGetListAll().FirstOrDefault();
            var map= _mapper.Map<AboutUpdateDto>(value);
            return View(map);
        }
        [Route("Index")]
        [HttpPost]
        public IActionResult Index(AboutUpdateDto dto)
        {
            var value = _aboutService.TGetById(dto.AboutId);
            value.Title = dto.Title;
            value.Description = dto.Description;
            value.Address = dto.Address;
            value.Phone = dto.Phone;
            value.CvUrl = dto.CvUrl;
            value.Name = dto.Name;
            value.Email = dto.Email;
            value.ProjectCount = dto.ProjectCount;
            _aboutService.TUpdate(value);
            return RedirectToAction("Index");
        }
    }
}
