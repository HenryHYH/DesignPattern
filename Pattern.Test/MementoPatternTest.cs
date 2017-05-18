using Pattern.MementoPattern;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Pattern.Test
{
    public class MementoPatternTest
    {
        [Fact]
        public void Test()
        {
            IList<Person> persons = new List<Person>()
            {
                new Person { Name = "电信", Mobile = "10000" },
                new Person { Name = "移动", Mobile = "10086" }
            };

            MobileOwner owner = new MobileOwner(persons);
            owner.Show();

            Caretaker caretaker = new Caretaker();
            caretaker.ContactMemontos.Add(DateTime.Now.ToString(), owner.CreateMemento());

            Console.WriteLine("移除最后一个联系人");
            owner.Persons.RemoveAt(1);
            owner.Show();

            Thread.Sleep(1000);
            caretaker.ContactMemontos.Add(DateTime.Now.ToString(), owner.CreateMemento());

            Console.WriteLine("恢复联系人");
            var keyCollection = caretaker.ContactMemontos.Keys;
            foreach (var key in keyCollection)
            {
                if (caretaker.ContactMemontos.TryGetValue(key, out ContactMemento contactMemento))
                {
                    Console.WriteLine("恢复{0}备份的联系人", key);
                    owner.RestoreMemento(contactMemento);
                    owner.Show();
                }
            }

            Assert.Equal(1, 1);
        }
    }
}
