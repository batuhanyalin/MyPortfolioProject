using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.DtoLayer.ContactDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public DefaultController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactCreateDto dto)
        {
            if (ModelState.IsValid)
            {
                var map = _mapper.Map<Contact>(dto);
                _contactService.TInsert(map);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult error404()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult error403()
        {
            return View();
        }
    }
}
