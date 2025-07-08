using Portfolio.API.Models.Post;
using Portfolio.Core.Entities;
using AutoMapper;
using System.Data;
using Portfolio.API.Models.DTOs;


namespace Portfolio.API
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<ProjectPostModel, Project>();
            CreateMap<MyProfilePostModel, MyProfile>();
            CreateMap<ExperiencePostModel, Experience>();
            CreateMap<SkillPostModel, Skill>();
            CreateMap<Experience, ExperienceDto>().ReverseMap();

        }

    }
}
