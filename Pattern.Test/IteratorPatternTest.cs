using Pattern.IteratorPattern;
using System;
using Xunit;

namespace Pattern.Test
{
    public class IteratorPatternTest
    {
        [Fact]
        public void Test()
        {
            IListCollection<int> list = new ConcreteList<int>(new[] { 2, 4, 6, 8 });
            var iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = iterator.GetCurrent();
                Console.WriteLine(i);
                iterator.Next();
            }

            Assert.Equal(1, 1);
        }
    }
}
