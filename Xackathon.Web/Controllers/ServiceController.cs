using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("services")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        [HttpPost("address")]
        public IActionResult Address([FromBody] string val)
        {
            return BadRequest(new { val });
        }

        [HttpPost("coords")]
        public IActionResult Coords([FromBody] string val)
        {
            return BadRequest();
        }

        [HttpPost("mailing")]
        public IActionResult Mailing([FromBody]string val)
        {
            return BadRequest();
        }

        [HttpPost("statistic")]
        public IActionResult Statistic([FromBody] string val)
        {
            return BadRequest();
        }

        [HttpPost("heatmap")]
        public IActionResult Heatmap([FromBody] string val)
        {
            return BadRequest();
        }

        [HttpPost("request/import")]
        public IActionResult Import([FromBody] string val)
        {
            return BadRequest();
        }

        [HttpPost("request/export")]
        public IActionResult Export([FromBody] string val)
        {
            return BadRequest();
        }
    }
}
