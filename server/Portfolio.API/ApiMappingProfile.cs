using Portfolio.API.Models.Post;
using Portfolio.Core.Entities;
using AutoMapper;
using System.Data;


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

        }

    }
}
