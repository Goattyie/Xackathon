using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("requests")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        [HttpGet("{requestId}")]
        public IActionResult GetRequest(long requestId)
        {
            return BadRequest(requestId);
        }

        [HttpPut("{requestId}")]
        public IActionResult PutRequest(long requestId)
        {
            return BadRequest(requestId);
        }

        [HttpDelete("{requestId}")]
        public IActionResult DeleteRequest(long requestId)
        {
            return BadRequest(requestId);
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

        [HttpPost("in-range")]
        public IActionResult PostInRange()
        {
            return BadRequest();
        }

        [HttpPost("rating")]
        public IActionResult PostRating()
        {
            return BadRequest();
        }

        [HttpGet("{requestId}/pdf")]
        public IActionResult GetRequestInPdf(long requestId)
        {
            return BadRequest(requestId);
        }

        [HttpGet("{requestId}/watch")]
        public IActionResult GetRequestWatch(long requestId)
        {
            return BadRequest(requestId);
        }
    }
}
