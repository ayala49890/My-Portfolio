using Portfolio.API.Models.DTOs;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Services
{
    public interface ISkillService
    {
        Task<List<SkillDto>> GetAllAsync();
        Task<SkillDto> GetByIdAsync(int id);
        Task AddAsync(Skill skill);
        Task UpdateAsync(int id, Skill skill);
        Task DeleteAsync(int id);
    }

}
