namespace Pattern.MediatorPattern
{
    public abstract class Mediator
    {
        protected CardPartner A;
        protected CardPartner B;

        public Mediator(CardPartner a, CardPartner b)
        {
            A = a;
            B = b;
        }

        public abstract void AWin(int count);

        public abstract void BWin(int count);
    }
}
