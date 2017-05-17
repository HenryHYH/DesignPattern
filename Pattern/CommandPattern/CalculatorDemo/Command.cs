namespace Pattern.CommandPattern.CalculatorDemo
{
    public abstract class Command
    {
        public abstract int Execute();

        public abstract int UnExecute();
    }
}
