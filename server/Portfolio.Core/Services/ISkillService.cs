using Portfolio.API.Models.DTOs;
using Portfolio.API.Models.Post;
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
        Task AddAsync(SkillPostModel model);
        Task UpdateAsync(int id, SkillPostModel model);
        Task DeleteAsync(int id);
    }

}
