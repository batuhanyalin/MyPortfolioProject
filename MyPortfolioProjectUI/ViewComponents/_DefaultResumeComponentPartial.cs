using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.ResumeDtos;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultResumeComponentPartial : ViewComponent
    {
        private readonly IResumeService _ResumeService;
        private readonly IMapper _mapper;

        public _DefaultResumeComponentPartial(IResumeService ResumeService, IMapper mapper)
        {
            _ResumeService = ResumeService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ResumeService.TGetListAll().OrderByDescending(x=>x.ResumeId);
            var map = _mapper.Map<List<ResumeListDto>>(values);
            return View(map);
        }
    }
}
