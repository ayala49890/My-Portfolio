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
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _repository;
        private readonly IMapper _mapper;

        public ProfileService(IProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProfileDto> GetProfileAsync()
        {
            var profile = await _repository.GetAsync();
            return _mapper.Map<ProfileDto>(profile);
        }

        public async Task UpdateProfileAsync(ProfilePostModel model)
        {
            var entity = _mapper.Map<AutoMapper.Profile>(model);
            await _repository.UpdateAsync(entity);
        }
    }
}
