using Portfolio.API.Models.DTOs;
using Portfolio.API.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Services
{
    public interface IProjectService
    {
        Task<List<ProjectDto>> GetAllAsync();
        Task<ProjectDto> GetByIdAsync(int id);
        Task AddAsync(ProjectPostModel model);
        Task UpdateAsync(int id, ProjectPostModel model);
        Task DeleteAsync(int id);
    }

}
