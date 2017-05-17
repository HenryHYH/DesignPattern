namespace Pattern.FlyweightPattern
{
    public abstract class Order
    {
        public abstract void Serve(Table table);

        public abstract string GetFlavor();
    }
}
