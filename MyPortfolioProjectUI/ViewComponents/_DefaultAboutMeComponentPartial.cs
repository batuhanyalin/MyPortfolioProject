using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.AboutDtos;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultAboutMeComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public _DefaultAboutMeComponentPartial(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values= _aboutService.TGetAboutList();
            var map= _mapper.Map<AboutListDto>(values);
            TempData["CvUrl"]=map.CvUrl;
            return View(map);
        }
    }
}
