
using Microsoft.AspNetCore.Mvc;
using CloudDecisionTree.API.Models;
using CloudDecisionTree.API.Services;

namespace CloudDecisionTree.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DecisionController : ControllerBase
    {
        private readonly DecisionEngine _engine = new DecisionEngine();

        [HttpPost("evaluate")]
        public IActionResult Evaluate([FromBody] DecisionInput input)
        {
            var result = _engine.Evaluate(input);
            return Ok(result);
        }
    }
}
