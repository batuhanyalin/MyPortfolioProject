using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.AboutDtos;
using MyPortfolioProject.DtoLayer.SocialMediaDtos;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultFooterSocialMediaComponentPartial : ViewComponent
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public _DefaultFooterSocialMediaComponentPartial(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values= _socialMediaService.TGetListAll();
            var map= _mapper.Map<List<SocialMediaListDto>>(values);
            return View(map);
        }
    }
}
