using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("regions")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        [HttpGet("{regionId}")]
        public IActionResult GetRegion(long regionId)
        {
            return BadRequest();
        }

        [HttpPut("{regionId}")]
        public IActionResult PutRegion(long regionId)
        {
            return BadRequest();
        }

        [HttpDelete("{regionId}")]
        public IActionResult DeleteRegion(long regionId)
        {
            return BadRequest();
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
