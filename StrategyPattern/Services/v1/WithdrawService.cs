using StrategyPattern.Contracts.v1;
using StrategyPattern.Models.v1;

namespace StrategyPattern.Services.v1
{
    public class WithdrawService : IStrategy<Withdraw>
    {
        public double GetValue(double value)
        {
            return value + (value * 0.07);
        }
    }
}
