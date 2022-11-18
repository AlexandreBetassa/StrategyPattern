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

        public ValuesController(IEnumerable<IStrategy> strategy) => _strategy = strategy;

        [HttpGet]
        public ActionResult<double> Get(double value, string type) =>
            _strategy
            .Where(item => item
            .GetType().Name
            .Contains(type))
            .First().GetValue(value);
    }
}
