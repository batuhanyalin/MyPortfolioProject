using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.BusinessLayer.ValidationRules;
using MyPortfolioProject.DtoLayer.ResumeDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ResumeController : Controller
    {
        private readonly IResumeService _ResumeService;
        private readonly IMapper _mapper;
        public ResumeController(IResumeService ResumeService, IMapper mapper)
        {
            _ResumeService = ResumeService;
            _mapper = mapper;
        }

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var value = _ResumeService.TGetListAll();
            var map = _mapper.Map<List<ResumeListDto>>(value);
            return View(map);
        }
        [Route("DeleteResume/{id:int}")]
        public IActionResult DeleteResume(int id)
        {
            _ResumeService.TDelete(id);
            return RedirectToAction("Index");
        }
        [Route("UpdateResume/{id:int}")]
        [HttpGet]
        public IActionResult UpdateResume(int id)
        {
            var value = _ResumeService.TGetById(id);
            var map = _mapper.Map<ResumeUpdateDto>(value);
            return View(map);
        }
        [Route("UpdateResume/{id:int}")]
        [HttpPost]
        public IActionResult UpdateResume(ResumeUpdateDto dto)
        {
            var validation = new ResumeUpdateValidator().Validate(dto);
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
                var value = _ResumeService.TGetById(dto.ResumeId);
                value.Title = dto.Title;
                value.Location = dto.Location;
                value.Date = dto.Date;
                value.Description = dto.Description;
                _ResumeService.TUpdate(value);
                return RedirectToAction("Index");
            }

        }
        [Route("CreateResume")]
        [HttpGet]
        public IActionResult CreateResume()
        {
            return View();
        }
        [Route("CreateResume")]
        [HttpPost]
        public IActionResult CreateResume(ResumeCreateDto dto)
        {
            var validation = new ResumeCreateValidator().Validate(dto);
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
                var map = _mapper.Map<Resume>(dto);
                _ResumeService.TInsert(map);
                return RedirectToAction("Index");
            }
        }
    }
}
