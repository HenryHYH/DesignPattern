using System.Collections.Generic;

namespace Pattern.ObserverPattern
{
    public abstract class Subject
    {
        private IList<IObserver> observers = new List<IObserver>();

        public string Symbol { get; private set; }

        public string Info { get; private set; }

        public Subject(string symbol, string info)
        {
            Symbol = symbol;
            Info = info;
        }

        public void Add(IObserver ob)
        {
            observers.Add(ob);
        }

        public void Remove(IObserver ob)
        {
            observers.Remove(ob);
        }

        public void Notify()
        {
            foreach (var item in observers)
                if (null != item)
                    item.Update(this);
        }
    }
}
