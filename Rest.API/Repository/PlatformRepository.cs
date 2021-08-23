using Rest.API.Data;
using Rest.API.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Rest.API.Repository
{
    public class PlatformRepository : IPlatformRepository
    {
        private readonly AppDbContext context;

        public PlatformRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Platform>> GetAsync()
        {
            return await context.Platforms.ToListAsync();
        }

    }
}
