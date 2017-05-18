using System;
using System.Collections.Generic;

namespace Pattern.MementoPattern
{
    public class MobileOwner
    {
        public IList<Person> Persons { get; private set; }

        public MobileOwner(IList<Person> persons)
        {
            Persons = persons;
        }

        public ContactMemento CreateMemento()
        {
            return new ContactMemento(new List<Person>(Persons));
        }

        public void RestoreMemento(ContactMemento memento)
        {
            if (null != memento)
                Persons = memento.PersonBack;
        }

        public void Show()
        {
            Console.WriteLine("联系人列表中有{0}人", Persons.Count);
            foreach (var item in Persons)
                Console.WriteLine("姓名：{0} 号码：{1}", item.Name, item.Mobile);
        }
    }
}
