using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.SkillDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class SkillController : Controller
    {
        private readonly ISkillService _SkillService;
        private readonly IMapper _mapper;
        public SkillController(ISkillService SkillService, IMapper mapper)
        {
            _SkillService = SkillService;
            _mapper = mapper;
        }

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var value = _SkillService.TGetListAll();
            var map = _mapper.Map<List<SkillListDto>>(value);
            return View(map);
        }
        [Route("DeleteSkill/{id:int}")]
        public IActionResult DeleteSkill(int id)
        {
            _SkillService.TDelete(id);           
            return RedirectToAction("Index");
        }
        [Route("UpdateSkill/{id:int}")]
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = _SkillService.TGetById(id);
            var map = _mapper.Map<SkillUpdateDto>(value);
            return View(map);
        }
        [Route("UpdateSkill/{id:int}")]
        [HttpPost]
        public IActionResult UpdateSkill(SkillUpdateDto dto)
        {
            var value = _SkillService.TGetById(dto.SkillId);
            value.Title = dto.Title;
            value.Rate = dto.Rate;
            _SkillService.TUpdate(value);
            return RedirectToAction("Index");

        }
        [Route("CreateSkill")]
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [Route("CreateSkill")]
        [HttpPost]
        public IActionResult CreateSkill(SkillCreateDto dto)
        {
            var map = _mapper.Map<Skill>(dto);
            _SkillService.TInsert(map);
            return RedirectToAction("Index");
        }
    }
}
