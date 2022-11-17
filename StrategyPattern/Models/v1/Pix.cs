using StrategyPattern.Contracts.v1;

namespace StrategyPattern.Models.v1
{
    public class Pix : IEntity
    {
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
    }
}
