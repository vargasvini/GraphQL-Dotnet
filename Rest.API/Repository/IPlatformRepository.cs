using Rest.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.API.Repository
{
    public interface IPlatformRepository
    {
        Task<IEnumerable<Platform>> GetAsync();
    }
}
