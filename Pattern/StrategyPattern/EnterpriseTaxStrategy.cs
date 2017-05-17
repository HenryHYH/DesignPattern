namespace Pattern.StrategyPattern
{
    public class EnterpriseTaxStrategy : ITaxStrategy
    {
        public double Calculate(double income)
        {
            return (income - 3500) > 0 ? (income - 3500) * 0.045 : 0.0;
        }
    }
}
