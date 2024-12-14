using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.ProjectDtos;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultMyProjectComponentPartial : ViewComponent
    {
        private readonly IProjectService _ProjectService;
        private readonly IMapper _mapper;

        public _DefaultMyProjectComponentPartial(IProjectService ProjectService, IMapper mapper)
        {
            _ProjectService = ProjectService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ProjectService.TGetListAll().OrderByDescending(x => x.ProjectId);
            var map = _mapper.Map<List<ProjectListDto>>(values);
            return View(map);
        }
    }
}
