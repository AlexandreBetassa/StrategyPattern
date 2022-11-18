using StrategyPattern.Contracts.v1;
using StrategyPattern.Models.v1;

namespace StrategyPattern.Services.v1
{
    public class CreditCardService : IStrategy<CreditCard>
    {
        public double GetValue(double value)
        {
            return value + (value * 0.1);
        }
    }
}
