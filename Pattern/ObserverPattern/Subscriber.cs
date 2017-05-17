using System;

namespace Pattern.ObserverPattern
{
    public class Subscriber : IObserver
    {
        public string Name { get; private set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(Subject subject)
        {
            Console.WriteLine("Notified {0} of {1}'s Info is {2}", Name, subject.Symbol, subject.Info);
        }
    }
}
