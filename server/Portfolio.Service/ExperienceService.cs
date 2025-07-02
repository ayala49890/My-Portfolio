using AutoMapper;
using Portfolio.API.Models.DTOs;
using Portfolio.API.Models.Post;
using Portfolio.Core.Entities;
using Portfolio.Core.Repositories;
using Portfolio.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Service
{
    public class ExperienceService : IExperienceService
    {
        private readonly IExperienceRepository _repository;
        private readonly IMapper _mapper;

        public ExperienceService(IExperienceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ExperienceDto>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync();
            return _mapper.Map<List<ExperienceDto>>(data);
        }

        public async Task<ExperienceDto?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity is null ? null : _mapper.Map<ExperienceDto>(entity);
        }

        public async Task AddAsync(ExperiencePostModel model)
        {
            var entity = _mapper.Map<Experience>(model);
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(int id, ExperiencePostModel model)
        {
            var entity = _mapper.Map<Experience>(model);
            entity.Id = id;
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }

}
