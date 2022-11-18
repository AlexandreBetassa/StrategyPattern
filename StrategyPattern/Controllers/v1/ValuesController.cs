using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Contracts.v1;
using StrategyPattern.Enum.v1;
using StrategyPattern.Services.v1;

namespace StrategyPattern.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IStrategy<IEntity> _strategy;

        public ValuesController(IStrategy<IEntity> strategy)
        {
            _strategy = strategy;
        }

        [HttpPost]
        public ActionResult<double> Post(double value, TypeOperation type)
        {
            IServiceCollection config = config.AddScoped<IStrategy<IEntity>>(x => x.GetRequiredService<IStrategy<IEntity>>());
            return _strategy.GetValue(value);
        }

        public IStrategy<IEntity> GetStrategy(TypeOperation type)
        {
            switch (type)
            {
                case TypeOperation.Pix:
                    return IStrategy<Pix>;
            }


            return null;
        }

    }
}
