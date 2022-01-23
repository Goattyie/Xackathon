using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xackathon.Bll.Model;
using Xackathon.Bll.Service;
using Xackathon.Web.Models;

namespace Xackathon.Web.Controllers
{
    [Route("stories")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private readonly IStoryService _service;

        public StoryController(IStoryService service)
        {
            _service = service;
        }
        [HttpGet("{storyId}")]
        public async Task<IActionResult> GetStory(long storyId)
        {
            var domain = await _service.GetById(storyId);

            return Ok(domain);
        }

        [HttpPut("{storyId}")]
        public async Task<IActionResult> PutStory(long storyId, [FromBody]StoryForm story)
        {
            var domain = await _service.Update(storyId, (StoryDomainModel)story);
            
            return Ok(domain);
        }

        [HttpDelete("{storyId}")]
        public async Task<IActionResult> DeleteStory(long storyId)
        {
            var domain = await _service.Delete(storyId);

            return Ok(domain);
        }

        [HttpPost("{storyId}/watch")]
        public async Task<IActionResult> PostStory(long storyId)
        {
            var domain = await _service.Watch(storyId);

            return Ok(domain);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var list = _service.Get();

            return Ok(list.ToStoryViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]StoryForm story)
        {
            var domain = await _service.Create((StoryDomainModel)story);

            return Ok(domain);
        }
    }
}
