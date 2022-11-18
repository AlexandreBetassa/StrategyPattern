using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Contracts.v1;
using StrategyPattern.Enum.v1;
using StrategyPattern.Models.v1;
using StrategyPattern.Services.v1;

namespace StrategyPattern.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IStrategy _strategy;

        public ValuesController(IStrategy strategy)
        {
            _strategy = strategy;
        }

        [HttpPost]
        public ActionResult<double> Post(double value, TypeOperation type)
        {
            return _strategy.GetValue(value);
        }

    }
}
