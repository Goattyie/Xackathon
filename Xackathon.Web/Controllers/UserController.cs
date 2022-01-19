using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("{userId}")]
        public IActionResult GetUser(long userId)
        {
            return BadRequest(userId);
        }

        [HttpPut("{userId}")]
        public IActionResult Put(long userId)
        {
            return BadRequest(userId);
        }

        [HttpDelete("{userId}")]
        public IActionResult Delete(long userId)
        {
            return BadRequest(userId);
        }

        [HttpGet("me")]
        public IActionResult GetMe()
        {
            return BadRequest();
        }

        [HttpGet("{userId}/profile")]
        public IActionResult GetProfile(long userId)
        {
            return BadRequest(userId);
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

        [HttpPut("{userId}/roles")]
        public IActionResult PutRoles(long userId)
        {
            return BadRequest(userId);
        }

        [HttpGet("{userId}/blocked")]
        public IActionResult GetBlocked(long userId)
        {
            return BadRequest(userId);
        }

        [HttpGet("{userId}/unblocked")]
        public IActionResult GetUnblocked(long userId)
        {
            return BadRequest(userId);
        }
    }
}
