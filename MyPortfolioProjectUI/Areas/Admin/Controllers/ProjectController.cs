using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioProject.BusinessLayer.Abstract;
using MyPortfolioProject.BusinessLayer.ValidationRules;
using MyPortfolioProject.DtoLayer.ProjectDtos;
using MyPortfolioProject.DtoLayer.RegisterDtos;
using MyPortfolioProject.EntityLayer.Concrete;
using Newtonsoft.Json.Linq;

namespace MyPortfolioProjectUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ProjectController : Controller
    {
        private readonly IProjectService _ProjectService;
        private readonly IMapper _mapper;
        public ProjectController(IProjectService ProjectService, IMapper mapper)
        {
            _ProjectService = ProjectService;
            _mapper = mapper;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _ProjectService.TGetListAll();
            var map = _mapper.Map<List<ProjectListDto>>(values);
            return View(map);
        }
        [Route("DeleteProject/{id:int}")]
        public IActionResult DeleteProject(int id)
        {
            _ProjectService.TDelete(id);
            return RedirectToAction("Index");
        }
        [Route("UpdateProject/{id:int}")]
        [HttpGet]
        public IActionResult UpdateProject(int id)
        {
            var value = _ProjectService.TGetById(id);
            var map = _mapper.Map<ProjectUpdateDto>(value);
            return View(map);
        }
        [Route("UpdateProject/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> UpdateProject(ProjectUpdateDto dto, IFormFile Image)
        {
            var validation = new ProjectUpdateValidator().Validate(dto);
            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(dto);
            }
            else
            {
                var thisProject = _ProjectService.TGetById(dto.ProjectId);

                if (Image != null && Image.Length > 0)
                {
                    var source = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(Image.FileName);
                    var imageName = Guid.NewGuid() + extension;
                    var saveLocation = Path.Combine(source, "wwwroot/images/projectPhotos/", imageName);
                    using (var stream = new FileStream(saveLocation, FileMode.Create))
                    {
                        await Image.CopyToAsync(stream);
                    }
                    dto.ImageUrl = $"/images/projectPhotos/{imageName}";
                    thisProject.ImageUrl = dto.ImageUrl;
                }

                if (thisProject.ImageUrl == null)
                {
                    thisProject.ImageUrl = $"/images/project-5.jpg";
                }

                thisProject.Title = dto.Title;
                thisProject.Description = dto.Description;
                thisProject.Date = dto.Date;
                thisProject.Url = dto.Url;
                _ProjectService.TUpdate(thisProject);
                return RedirectToAction("Index");
            }

        }
        [Route("CreateProject")]
        [HttpGet]
        public IActionResult CreateProject()
        {
            return View();
        }
        [Route("CreateProject")]
        [HttpPost]
        public async Task<IActionResult> CreateProject(ProjectCreateDto dto, IFormFile Image)
        {
            var validation = new ProjectCreateValidator().Validate(dto);
            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(dto);
            }
            else
            {
                if (Image != null && Image.Length > 0)
                {
                    var source = Directory.GetCurrentDirectory();
                    var extension = Path.GetExtension(Image.FileName);
                    var imageName = Guid.NewGuid() + extension;
                    var saveLocation = Path.Combine(source, "wwwroot/images/projectPhotos/", imageName);
                    using (var stream = new FileStream(saveLocation, FileMode.Create))
                    {
                        await Image.CopyToAsync(stream);
                    }
                    dto.ImageUrl = $"/images/projectPhotos/{imageName}";
                }
                else if (dto.ImageUrl == null)
                {
                    dto.ImageUrl = $"/images/project-5.jpg";
                }
                var map = _mapper.Map<Project>(dto);
                _ProjectService.TInsert(map);
                return RedirectToAction("Index");
            }
        }
    }
}
