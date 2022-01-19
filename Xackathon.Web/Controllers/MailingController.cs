using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("mailing")]
    [ApiController]
    public class MailingController : ControllerBase
    {
        [HttpGet("{mailingId}")]
        public IActionResult GetMailing(long mailingId)
        {
            return BadRequest();
        }

        [HttpPut("{mailingId}")]
        public IActionResult PutMailing(long mailingId)
        {
            return BadRequest();
        }

        [HttpDelete("{mailingId}")]
        public IActionResult DeleteMailing(long mailingId)
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

        [HttpGet("handler")]
        public IActionResult GetHandler()
        {
            return BadRequest();
        }
    }
}
