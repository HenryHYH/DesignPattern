using System;
using System.Collections.Generic;

namespace Pattern.FlyweightPattern
{
    public class FlyweightFactory
    {
        private IDictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight("A"));
            flyweights.Add("B", new ConcreteFlyweight("B"));
            flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.TryGetValue(key, out Flyweight item))
            {
                Console.WriteLine("创建享元{0}", key);

                item = new ConcreteFlyweight(key);
                flyweights.Add(key, item);
            }

            return item;
        }
    }
}
