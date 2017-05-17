namespace Pattern.StrategyPattern
{
    public class InterestOperation
    {
        private ITaxStrategy strategy;

        public InterestOperation(ITaxStrategy strategy)
        {
            this.strategy = strategy;
        }

        public double GetTax(double income)
        {
            return strategy.Calculate(income);
        }
    }
}
