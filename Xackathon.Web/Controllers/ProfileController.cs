using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("profiles")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet("{profileId}")]
        public IActionResult Get(long profileId)
        {
            return BadRequest(profileId);
        }

        [HttpPut("{profileId}")]
        public IActionResult Put(long profileId)
        {
            return BadRequest(profileId);
        }

        [HttpDelete("{profileId}")]
        public IActionResult Delete(long profileId)
        {
            return BadRequest(profileId);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return BadRequest();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return BadRequest();
        }
    }
}
