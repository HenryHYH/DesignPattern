namespace Pattern.MediatorPattern
{
    public class PlayerB : CardPartner
    {
        public override void ChangeCount(int count, Mediator mediator)
        {
            mediator.BWin(count);
        }
    }
}
