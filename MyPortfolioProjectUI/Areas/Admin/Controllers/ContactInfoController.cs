using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.BusinessLayer.ValidationRules;
using MyPortfolioProject.DtoLayer.AboutDtos;
using MyPortfolioProject.DtoLayer.ContactInfoDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ContactInfoController : Controller
    {
        private readonly IContactInfoService _ContactInfoService;
        private readonly IMapper _mapper;
        public ContactInfoController(IContactInfoService ContactInfoService, IMapper mapper)
        {
            _ContactInfoService = ContactInfoService;
            _mapper = mapper;
        }
        [Route("DeleteContactInfo/{id:int}")]
        public IActionResult DeleteContactInfo(int id)
        {
            _ContactInfoService.TDelete(id);
            return RedirectToAction("Index");
        }
        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var value = _ContactInfoService.TGetListAll();
            var map = _mapper.Map<List<ContactInfoListDto>>(value);
            return View(map);
        }
        [Route("UpdateContactInfo/{id:int}")]
        [HttpGet]
        public IActionResult UpdateContactInfo(int id)
        {
            var value = _ContactInfoService.TGetListAll().FirstOrDefault();
            var map = _mapper.Map<ContactInfoUpdateDto>(value);
            return View(map);
        }
        [Route("UpdateContactInfo/{id:int}")]
        [HttpPost]
        public IActionResult UpdateContactInfo(ContactInfoUpdateDto dto)
        {
            var validation = new ContactInfoUpdateValidator().Validate(dto);
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
                var value = _ContactInfoService.TGetById(dto.ContactInfoId);
                value.Title = dto.Title;
                value.Icon = dto.Icon;
                value.UrlText = dto.UrlText;
                value.Url = dto.Url;
                _ContactInfoService.TUpdate(value);
                return RedirectToAction("Index");
            }
        }
        [Route("CreateContactInfo")]
        [HttpGet]
        public IActionResult CreateContactInfo()
        {

            return View();
        }
        [Route("CreateContactInfo")]
        [HttpPost]
        public IActionResult CreateContactInfo(ContactInfoCreateDto dto)
        {
            var validation = new ContactInfoCreateValidator().Validate(dto);
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
                var map = _mapper.Map<ContactInfo>(dto);
                _ContactInfoService.TInsert(map);
                return RedirectToAction("Index");
            }

        }
    }
}
