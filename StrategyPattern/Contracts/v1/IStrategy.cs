namespace StrategyPattern.Contracts.v1
{
    public interface IStrategy<IEntity>
    {
        public double GetValue(double value);
    }
}
