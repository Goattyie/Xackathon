using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xackathon.Bll;
using Xackathon.Bll.Model;
using Xackathon.Bll.Service;
using Xackathon.Web.Models;

namespace Xackathon.Web.Controllers
{
    [Route("regions")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _service;

        public RegionController(IRegionService service)
        {
            _service = service;
        }
        [HttpGet("{regionId}")]
        public async Task<IActionResult> GetRegion(long regionId)
        {
            var region = await _service.GetById(regionId);

            return Ok(region);
        }

        [HttpPut("{regionId}")]
        public async Task<IActionResult> PutRegion(long regionId, [FromBody] RegionForm form)
        {
            var region = await _service.Update(regionId, (RegionDomainModel)form);

            return Ok(region);
        }

        [HttpDelete("{regionId}")]
        public async Task<IActionResult> DeleteRegion(long regionId)
        {
            var region = await _service.Delete(regionId);

            return Ok(region);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var regions = _service.Get();
            var viewModel = regions.ToRegionViewModel();

            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegionForm form)
        {
            var region = await _service.Create((RegionDomainModel)form);

            return Ok(region);
        }
    }
}
