using System.Collections.Generic;

namespace Pattern.MementoPattern
{
    public class ContactMemento
    {
        public IList<Person> PersonBack { get; private set; }

        public ContactMemento(IList<Person> persons)
        {
            PersonBack = persons;
        }
    }
}
