using StrategyPattern.Contracts.v1;

namespace StrategyPattern.Models.v1
{
    public class Withdraw : IEntity
    {
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
    }
}
