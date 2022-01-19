using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("problem-categories")]
    [ApiController]
    public class ProblemCategory : ControllerBase
    {
        [HttpGet("{problemCategoryId}")]
        public IActionResult GetCategory(long problemCategoryId)
        {
            return BadRequest(problemCategoryId);
        }

        [HttpPut("{problemCategoryId}")]
        public IActionResult PutCategory(long problemCategoryId)
        {
            return BadRequest(problemCategoryId);
        }

        [HttpDelete("{problemCategoryId}")]
        public IActionResult DeleteCategory(long problemCategoryId)
        {
            return BadRequest(problemCategoryId);
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

        [HttpGet("{problemCategoryId}/active-request")]
        public IActionResult GetCategoryActiveRequest(long problemCategoryId) 
        {
            return BadRequest();
        }

        [HttpGet("{problemCategoryId}/completed-request")]
        public IActionResult GetCategoryCompletedRequest(long problemCategoryId)
        {
            return BadRequest();
        }

        [HttpGet("{problemCategoryId}/archive-request")]
        public IActionResult GetCategoryArchiveRequest(long problemCategoryId)
        {
            return BadRequest();
        }
    }
}
