using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Core.Repositories
{
    public interface IProfileRepository
    {
        Task<Profile> GetAsync();
        Task UpdateAsync(Profile profile);
        Task UpdateAsync(AutoMapper.Profile entity);
    }

}
