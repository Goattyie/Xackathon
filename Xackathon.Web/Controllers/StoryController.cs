using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("stories")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        [HttpGet("{storyId}")]
        public IActionResult GetStory(long storyId)
        {
            return BadRequest();
        }

        [HttpPut("{storyId}")]
        public IActionResult PutStory(long storyId)
        {
            return BadRequest();
        }

        [HttpDelete("{storyId}")]
        public IActionResult DeleteStory(long storyId)
        {
            return BadRequest();
        }

        [HttpPost("{storyId}/watch")]
        public IActionResult PostStory(long storyId)
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
