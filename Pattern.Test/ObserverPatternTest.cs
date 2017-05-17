using Pattern.ObserverPattern;
using Xunit;

namespace Pattern.Test
{
    public class ObserverPatternTest
    {
        [Fact]
        public void Test()
        {
            Subject subject = new ConcreteSubject("Hello", "Message");
            subject.Add(new Subscriber("A"));
            subject.Add(new Subscriber("B"));

            subject.Notify();

            Assert.Equal(1, 1);
        }
    }
}
