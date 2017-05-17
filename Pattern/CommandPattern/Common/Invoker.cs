namespace Pattern.CommandPattern.Common
{
    public class Invoker
    {
        private Command command;

        public Invoker(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Action();
        }
    }
}
