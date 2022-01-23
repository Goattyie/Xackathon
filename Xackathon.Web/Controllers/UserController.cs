using Microsoft.AspNetCore.Mvc;
using Xackathon.Bll.Model;
using Xackathon.Bll.Service;
using Xackathon.Dal.Models;
using Xackathon.Sql.Repository;
using Xackathon.Web.Models;

namespace Xackathon.Web.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(long userId)
        {
            var user = await _service.GetById(userId);

            return Ok(user);
        }

        [HttpPut("{userId}")]
        public async Task<IActionResult> Put(long userId, [FromBody] UserForm obj)
        {
            var user = await _service.Update(userId, (UserDomainModel)obj);

            return Ok(user);
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(long userId)
        {
            var user = await _service.Delete(userId);

            return Ok(user);
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
            var list = _service.Get();

            return Ok(list);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]UserForm obj)
        {
            var user = await _service.Create((UserDomainModel)obj);

            return Ok(user);
        }

        [HttpPut("{userId}/roles")]
        public async Task<IActionResult> PutRoles(long userId, [FromBody] IEnumerable<RoleDomainModel> obj)
        {
            var user = await _service.Update(userId, (UserDomainModel)obj);

            return Ok(user);
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
