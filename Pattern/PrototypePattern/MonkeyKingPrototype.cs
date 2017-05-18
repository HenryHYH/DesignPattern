namespace Pattern.PrototypePattern
{
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; private set; }

        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        public abstract MonkeyKingPrototype Clone();
    }
}
