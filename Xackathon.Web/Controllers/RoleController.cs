using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("roles")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        [HttpGet("{roleId}")]
        public IActionResult GetRole(long roleId)
        {
            return BadRequest();
        }

        [HttpPut("{roleId}")]
        public IActionResult PutRole(long roleId)
        {
            return BadRequest();
        }

        [HttpDelete("{roleId}")]
        public IActionResult DeleteRole(long roleId)
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
