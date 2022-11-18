using StrategyPattern.Contracts.v1;

namespace StrategyPattern.Services.v1
{
    public class CreditCardService : IStrategy
    {
        public double GetValue(double value)
        {
            return value + (value * 0.1);
        }
    }
}
