namespace Pattern.PrototypePattern
{
    public class ConcretePrototype : MonkeyKingPrototype
    {
        public ConcretePrototype(string id)
            : base(id)
        {
        }

        public override MonkeyKingPrototype Clone()
        {
            // 浅拷贝
            return (MonkeyKingPrototype)MemberwiseClone();
        }
    }
}
