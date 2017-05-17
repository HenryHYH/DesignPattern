namespace Pattern.CommonPattern
{
    public class ConcerteCommand : Command
    {
        public ConcerteCommand(Receiver receiver)
            : base(receiver)
        {
        }

        public override void Action()
        {
            receiver.Run();
        }
    }
}
