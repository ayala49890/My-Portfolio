using AutoMapper;
using Portfolio.API.Models.DTOs;
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
    public class MyProfileService : IMyProfileService
    {
        private readonly IMyProfileRepository _repository;
        private readonly IMapper _mapper;

        public MyProfileService(IMyProfileRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<MyProfileDto> GetProfileAsync()
        {
            var profile = await _repository.GetAsync();
            return _mapper.Map<MyProfileDto>(profile);
        }

        public Task UpdateMyProfileAsync(MyProfile myProfile)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProfileAsync(MyProfile myProfile)
        {
            var entity = _mapper.Map<AutoMapper.Profile>(myProfile);
            await _repository.UpdateAsync(entity);
        }
    }
}
