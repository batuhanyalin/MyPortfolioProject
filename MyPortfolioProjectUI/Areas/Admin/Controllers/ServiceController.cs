using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.BusinessLayer.ValidationRules;
using MyPortfolioProject.DtoLayer.ServiceDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _ServiceService;
        private readonly IMapper _mapper;
        public ServiceController(IServiceService ServiceService, IMapper mapper)
        {
            _ServiceService = ServiceService;
            _mapper = mapper;
        }

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var value = _ServiceService.TGetListAll();
            var map = _mapper.Map<List<ServiceListDto>>(value);
            return View(map);
        }
        [Route("DeleteService/{id:int}")]
        public IActionResult DeleteService(int id)
        {
            _ServiceService.TDelete(id);
            return RedirectToAction("Index");
        }
        [Route("UpdateService/{id:int}")]
        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = _ServiceService.TGetById(id);
            var map = _mapper.Map<ServiceUpdateDto>(value);
            return View(map);
        }
        [Route("UpdateService/{id:int}")]
        [HttpPost]
        public IActionResult UpdateService(ServiceUpdateDto dto)
        {
                var value = _ServiceService.TGetById(dto.ServiceId);
                value.Title = dto.Title;
                value.Icon = dto.Icon;
                value.Url = dto.Url;
                _ServiceService.TUpdate(value);
                return RedirectToAction("Index");

        }
        [Route("CreateService")]
        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }
        [Route("CreateService")]
        [HttpPost]
        public IActionResult CreateService(ServiceCreateDto dto)
        {
                var map = _mapper.Map<Service>(dto);
                _ServiceService.TInsert(map);
                return RedirectToAction("Index");
        }
    }
}
