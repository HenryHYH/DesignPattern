namespace Pattern.StrategyPattern
{
    public class PersonalTaxStrategy : ITaxStrategy
    {
        public double Calculate(double income)
        {
            return income * 0.12;
        }
    }
}
