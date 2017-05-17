using System;

namespace Pattern.FlyweightPattern
{
    public class ConcreteFlyweight : Flyweight
    {
        private string innerState;

        public ConcreteFlyweight(string innerState)
        {
            this.innerState = innerState;
        }

        public override void Operation(int extState)
        {
            Console.WriteLine("具体实现：innerState = {0}; extState = {1};", innerState, extState);
        }
    }
}
