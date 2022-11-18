using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Contracts.v1;
using StrategyPattern.Enum.v1;


namespace StrategyPattern.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IEnumerable<IStrategy> _strategy;

        public ValuesController(IEnumerable<IStrategy> strategy)
        {
            _strategy = strategy;
        }

        [HttpPost]
        public ActionResult<string> Post(string value)
        {
            return value;
        }

    }
}
