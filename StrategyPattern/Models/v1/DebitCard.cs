using StrategyPattern.Contracts.v1;

namespace StrategyPattern.Models.v1
{
    public class DebitCard : IEntity
    {
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
    }
}
