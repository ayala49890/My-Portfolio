using Portfolio.API.Models.DTOs;
using Portfolio.Core.Entities;
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
        Task AddAsync(Experience experience);
        Task UpdateAsync(int id, Experience experience);
        Task DeleteAsync(int id);
    }

}
