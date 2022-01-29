using Microsoft.AspNetCore.Mvc;
using Xackathon.Bll.Model;
using Xackathon.Bll.Service;
using Xackathon.Web.Models;

namespace Xackathon.Web.Controllers
{
    [Route("problem-categories")]
    [ApiController]
    public class ProblemCategoryController : ControllerBase
    {
        private readonly IProblemCategoryService _db;

        public ProblemCategoryController(IProblemCategoryService db)
        {
            _db = db;
        }
        [HttpGet("{problemCategoryId}")]
        public async Task<IActionResult> GetCategory(long problemCategoryId)
        {
            var category = await _db.GetById(problemCategoryId);

            return Ok(category);
        }

        [HttpPut("{problemCategoryId}")]
        public async Task<IActionResult> PutCategory(long problemCategoryId, [FromBody] ProblemCategoryForm obj)
        {
            var domain = (ProblemCategoryDomainModel)obj;

            var updatedDomain = await _db.Update(problemCategoryId, domain);

            return Ok(updatedDomain);
        }

        [HttpDelete("{problemCategoryId}")]
        public async Task<IActionResult> DeleteCategory(long problemCategoryId)
        {
            var domain = await _db.Delete(problemCategoryId);

            return Ok(domain);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var problems = _db.Get();
            var viewModelList = Auto.Mapper.Map<IEnumerable<ProblemCategoryViewModel>>(problems);

            return Ok(viewModelList.ToViewModelList());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ProblemCategoryForm obj)
        {
            var domain = (ProblemCategoryDomainModel)obj;

            var newDomain = await _db.Create(domain);

            return Ok(newDomain);
        }
    }
}
