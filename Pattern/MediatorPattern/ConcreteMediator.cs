namespace Pattern.MediatorPattern
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteMediator(CardPartner a, CardPartner b)
            : base(a, b)
        {
        }

        public override void AWin(int count)
        {
            A.MoneyCount += count;
            B.MoneyCount -= count;
        }

        public override void BWin(int count)
        {
            B.MoneyCount += count;
            A.MoneyCount -= count;
        }
    }
}
