using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.ContactDtos;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ContactController : Controller
    {
        private readonly IContactService _ContactService;
        private readonly IMapper _mapper;
        public ContactController(IContactService ContactService, IMapper mapper)
        {
            _ContactService = ContactService;
            _mapper = mapper;
        }

        [Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            var value = _ContactService.TGetListAll();
            var map = _mapper.Map<List<ContactListDto>>(value);
            return View(map);
        }
        [Route("DeleteContact/{id:int}")]
        public IActionResult DeleteContact(int id)
        {
            _ContactService.TDelete(id);
            return RedirectToAction("Index");
        }

        [Route("ReadContact/{id:int}")]
        [HttpGet]
        public IActionResult ReadContact(int id)
        {
            var value = _ContactService.TGetById(id);
            var map = _mapper.Map<ContactListDto>(value);
            return View(map);
        }
    }
}
