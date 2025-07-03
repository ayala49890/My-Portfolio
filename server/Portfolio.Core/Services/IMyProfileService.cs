using Portfolio.API.Models.DTOs;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Services
{
    public interface IMyProfileService
    {
        Task<MyProfileDto> GetProfileAsync();
        Task UpdateMyProfileAsync(MyProfile myProfile);
    }

}
