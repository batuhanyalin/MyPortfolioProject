using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.BusinessLayer.ValidationRules;
using MyPortfolioProject.DtoLayer.SocialMediaDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _SocialMediaService;
        private readonly IMapper _mapper;
        public SocialMediaController(ISocialMediaService SocialMediaService, IMapper mapper)
        {
            _SocialMediaService = SocialMediaService;
            _mapper = mapper;
        }

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var value = _SocialMediaService.TGetListAll();
            var map = _mapper.Map<List<SocialMediaListDto>>(value);
            return View(map);
        }
        [Route("DeleteSocialMedia/{id:int}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            _SocialMediaService.TDelete(id);
            return RedirectToAction("Index");
        }
        [Route("UpdateSocialMedia/{id:int}")]
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var value = _SocialMediaService.TGetById(id);
            var map = _mapper.Map<SocialMediaUpdateDto>(value);
            return View(map);
        }
        [Route("UpdateSocialMedia/{id:int}")]
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMediaUpdateDto dto)
        {
            var validation = new SocialMediaUpdateValidator().Validate(dto);
            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(dto);
            }
            else
            {
                var value = _SocialMediaService.TGetById(dto.SocialMediaId);
                value.Name = dto.Name;
                value.Icon = dto.Icon;
                value.Url = dto.Url;
                _SocialMediaService.TUpdate(value);
                return RedirectToAction("Index");
            }

        }
        [Route("CreateSocialMedia")]
        [HttpGet]
        public IActionResult CreateSocialMedia()
        {
            return View();
        }
        [Route("CreateSocialMedia")]
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMediaCreateDto dto)
        {
            var validation = new SocialMediaCreateValidator().Validate(dto);
            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(dto);
            }
            else
            {
                var map = _mapper.Map<SocialMedia>(dto);
                _SocialMediaService.TInsert(map);
                return RedirectToAction("Index");
            }
        }
    }
}
