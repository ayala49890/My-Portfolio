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
            CreateMap<MyProfilePostModel, MyProfile>();

            CreateMap<ExperiencePostModel, Experience>();
            CreateMap<Experience, ExperienceDto>().ReverseMap();
            CreateMap<ProjectPostModel, Project>();
            CreateMap<Project, ProjectDto>().ReverseMap();

            CreateMap<ProjectSkill, ProjectSkillPostModel>().ReverseMap();
            




        }

    }
}
