using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core
{
    using AutoMapper;
    using Portfolio.API.Models.DTOs;
    using Portfolio.Core.Entities;

    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            // Experience
            CreateMap<Experience, ExperienceDto>()
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate.ToString("yyyy-MM-dd")))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate.HasValue ? src.EndDate.Value.ToString("yyyy-MM-dd") : null)).ReverseMap();

            // Skill
            CreateMap<Skill, SkillDto>().ReverseMap();

            // Profile
            CreateMap<MyProfile, MyProfileDto>().ReverseMap();

            // Project (אם יש)
            CreateMap<Project, ProjectDto>().ReverseMap();
        }
    }


}
