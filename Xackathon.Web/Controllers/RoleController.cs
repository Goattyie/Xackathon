using Microsoft.AspNetCore.Mvc;
using Xackathon.Bll;
using Xackathon.Bll.Model;
using Xackathon.Web.Models;

namespace Xackathon.Web.Controllers
{
    [Route("roles")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly Services _services;

        public RoleController(Services services)
        {
            _services = services;
        }

        [HttpGet("{roleId}")]
        public async Task<IActionResult> GetRole(long roleId)
        {
            var role = await _services.RoleService.GetRole(roleId);
            return Ok(role);
        }

        [HttpPut("{roleId}")]
        public async Task<IActionResult> PutRole(long roleId, [FromBody] RoleForm model)
        {
            var domainModel = await _services.RoleService.UpdateRole(roleId, (RoleDomainModel)model);
            return Ok(domainModel);
        }

        [HttpDelete("{roleId}")]
        public async Task<IActionResult> DeleteRole(long roleId)
        {
            var domainModel = await _services.RoleService.DeleteRole(roleId);
            return Ok(domainModel);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var roles = _services.RoleService.Get();
            var viewModel = roles.ToRoleViewModel();
            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RoleForm model)
        {
            var domainModel = await _services.RoleService.Create((RoleDomainModel)model);
            return Ok(domainModel);
        }
    }
}
