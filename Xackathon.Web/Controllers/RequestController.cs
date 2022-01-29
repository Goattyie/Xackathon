using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Xackathon.Bll.Model;
using Xackathon.Bll.Service;
using Xackathon.Web.Models;

namespace Xackathon.Web.Controllers
{
    [Route("requests")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _service;

        public RequestController(IRequestService service)
        {
            _service = service;
        }
        [HttpGet("{requestId}")]
        public async Task<IActionResult> GetRequest(long requestId)
        {
            var request = await _service.GetById(requestId);

            return Ok(request.ToViewModel());
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
            var list = _service.Get();
            var viewModelList = list.ToViewModel();
            var viewModel = viewModelList.ToViewModelList();

            return Ok(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RequestForm obj)
        {
            var request = await _service.Create((RequestFormDomainModel)obj);

            return Ok(request);
        }

        [HttpGet("{requestId}/watch")]
        public IActionResult GetRequestWatch(long requestId)
        {
            return BadRequest(requestId);
        }
    }
}
