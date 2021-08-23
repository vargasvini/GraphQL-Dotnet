using Microsoft.AspNetCore.Mvc;
using Rest.API.Repository;
using System;
using System.Threading.Tasks;

namespace Rest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformRepository platformRepository;

        public PlatformController(IPlatformRepository platformRepository)
        {
            this.platformRepository = platformRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var platforms = await platformRepository.GetAsync();
                return StatusCode(200, platforms);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
