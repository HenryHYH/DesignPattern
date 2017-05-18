using System.Collections.Generic;

namespace Pattern.MementoPattern
{
    public class Caretaker
    {
        public IDictionary<string, ContactMemento> ContactMemontos { get; private set; }

        public Caretaker()
        {
            ContactMemontos = new Dictionary<string, ContactMemento>();
        }
    }
}
