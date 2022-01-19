using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("stored-requests")]
    [ApiController]
    public class StoredRequest : ControllerBase
    {
        [HttpGet("{storedRequestId}")]
        public IActionResult GetStoredRequest(long storedRequestId)
        {
            return BadRequest();
        }

        [HttpPut("{storedRequestId}")]
        public IActionResult PutStoredRequest(long storedRequestId)
        {
            return BadRequest();
        }

        [HttpDelete("{storedRequestId}")]
        public IActionResult DeleteStoredRequest(long storedRequestId)
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
