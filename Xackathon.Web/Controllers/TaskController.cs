using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("tasks")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet("{taskId}")]
        public IActionResult GetTask(long taskId)
        {
            return BadRequest();
        }

        [HttpPut("{taskId}")]
        public IActionResult PutTask(long taskId)
        {
            return BadRequest();
        }

        [HttpDelete("{taskId}")]
        public IActionResult DeleteTask(long taskId)
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
