using Portfolio.API.Models.DTOs;
using Portfolio.API.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Services
{
    public interface IProfileService
    {
        Task<ProfileDto> GetProfileAsync();
        Task UpdateProfileAsync(ProfilePostModel model);
    }

}
