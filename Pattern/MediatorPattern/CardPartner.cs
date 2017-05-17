namespace Pattern.MediatorPattern
{
    public abstract class CardPartner
    {
        public int MoneyCount { get; set; }

        public CardPartner()
        {
            MoneyCount = 0;
        }

        public abstract void ChangeCount(int count, Mediator mediator);
    }
}
