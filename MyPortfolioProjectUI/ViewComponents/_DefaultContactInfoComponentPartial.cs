using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.AboutDtos;
using MyPortfolioProject.DtoLayer.ContactInfoDtos;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultContactInfoComponentPartial : ViewComponent
    {
        private readonly IContactInfoService _contactInfoService;
        private readonly IMapper _mapper;

        public _DefaultContactInfoComponentPartial(IContactInfoService contactInfoService, IMapper mapper)
        {
            _contactInfoService = contactInfoService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _contactInfoService.TGetListAll();
            var map = _mapper.Map<List<ContactInfoListDto>>(values);
            return View(map);
        }
    }
}
