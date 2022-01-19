using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Xackathon.Web.Controllers
{
    [Route("contractors")]
    [ApiController]
    public class ContractorController : ControllerBase
    {
        [HttpGet("{contractorId}")]
        public IActionResult GetContractor(long contractorId)
        {
            return BadRequest();
        }

        [HttpPut("{contractorId}")]
        public IActionResult PutContractor(long contractorId)
        {
            return BadRequest();
        }

        [HttpDelete("{contractorId}")]
        public IActionResult DeleteContractor(long contractorId)
        {
            return BadRequest();
        }

        [HttpGet("{contractorId}/requests/archive")]
        public IActionResult GetContractorRequestArchive(long contractorId)
        {
            return BadRequest();
        }

        [HttpGet("{contractorId}/requests/active")]
        public IActionResult GetContractorRequestActive(long contractorId)
        {
            return BadRequest();
        }

        [HttpGet("{contractorId}/tasks")]
        public IActionResult GetContractorTasks(long contractorId)
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
