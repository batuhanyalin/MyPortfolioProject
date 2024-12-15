using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.ServiceDtos;

namespace MyPortfolioProjectUI.ViewComponents
{
    public class _DefaultUseTechnologyComponentPartial : ViewComponent
    {
        private readonly IServiceService _ServiceService;
        private readonly IMapper _mapper;

        public _DefaultUseTechnologyComponentPartial(IServiceService ServiceService, IMapper mapper)
        {
            _ServiceService = ServiceService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _ServiceService.TGetListAll().OrderByDescending(x => x.ServiceId);
            var map = _mapper.Map<List<ServiceListDto>>(values);
            return View(map);
        }
    }
}
