using Portfolio.API.Models.DTOs;
using Portfolio.API.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Services
{
    public interface IExperienceService
    {
        Task<List<ExperienceDto>> GetAllAsync();
        Task<ExperienceDto?> GetByIdAsync(int id);
        Task AddAsync(ExperiencePostModel model);
        Task UpdateAsync(int id, ExperiencePostModel model);
        Task DeleteAsync(int id);
    }

}
