using StrategyPattern.Contracts.v1;
using StrategyPattern.Models.v1;

namespace StrategyPattern.Services.v1
{
    public class DebitCardService : IStrategy<DebitCard>
    {
        public double GetValue(double value)
        {
            return value + (value * 0.09);
        }
    }
}
