namespace Pattern.MediatorPattern
{
    public class PlayerA : CardPartner
    {
        public override void ChangeCount(int count, Mediator mediator)
        {
            mediator.AWin(count);
        }
    }
}
