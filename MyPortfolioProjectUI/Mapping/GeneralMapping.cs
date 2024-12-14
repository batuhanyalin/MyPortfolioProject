using AutoMapper;
using MyPortfolioProject.DtoLayer.AboutDtos;
using MyPortfolioProject.DtoLayer.ContactDtos;
using MyPortfolioProject.DtoLayer.ContactInfoDtos;
using MyPortfolioProject.DtoLayer.ProjectDtos;
using MyPortfolioProject.DtoLayer.ResumeDtos;
using MyPortfolioProject.DtoLayer.ServiceDtos;
using MyPortfolioProject.DtoLayer.SkillDtos;
using MyPortfolioProject.DtoLayer.SocialMediaDtos;
using MyPortfolioProject.EntityLayer.Concrete;

namespace MyPortfolioProjectUI.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<About,AboutListDto>().ReverseMap();
            CreateMap<About,AboutUpdateDto>().ReverseMap();
            CreateMap<Contact,ContactUpdateDto>().ReverseMap();
            CreateMap<Contact,ContactListDto>().ReverseMap();
            CreateMap<Contact,ContactCreateDto>().ReverseMap();
            CreateMap<ContactInfo,ContactInfoListDto>().ReverseMap();
            CreateMap<ContactInfo,ContactInfoUpdateDto>().ReverseMap();
            CreateMap<Project,ProjectUpdateDto>().ReverseMap();
            CreateMap<Project,ProjectListDto>().ReverseMap();
            CreateMap<Resume,ResumeListDto>().ReverseMap();
            CreateMap<Resume,ResumeUpdateDto>().ReverseMap();
            CreateMap<Service,ServiceListDto>().ReverseMap();
            CreateMap<Service,ServiceUpdateDto>().ReverseMap();
            CreateMap<Service,ServiceCreateDto>().ReverseMap();
            CreateMap<Skill,SkillUpdateDto>().ReverseMap();
            CreateMap<Skill,SkillCreateDto>().ReverseMap();
            CreateMap<Skill,SkillListDto>().ReverseMap();
            CreateMap<SocialMedia,SocialMediaListDto>().ReverseMap();
            CreateMap<SocialMedia,SocialMediaCreateDto>().ReverseMap();
            CreateMap<SocialMedia,SocialMediaUpdateDto>().ReverseMap();
        }
    }
}
