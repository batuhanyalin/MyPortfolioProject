using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.SkillDtos;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultMySkillsComponentPartial : ViewComponent
    {
        private readonly ISkillService _SkillService;
        private readonly IMapper _mapper;

        public _DefaultMySkillsComponentPartial(ISkillService SkillService, IMapper mapper)
        {
            _SkillService = SkillService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _SkillService.TGetListAll();
            var map = _mapper.Map<List<SkillListDto>>(values);
            return View(map);
        }
    }
}
