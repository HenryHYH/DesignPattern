using Pattern.MediatorPattern;
using Xunit;

namespace Pattern.Test
{
    public class MediatorPatternTest
    {
        [Fact]
        public void Test()
        {
            CardPartner a = new PlayerA();
            CardPartner b = new PlayerB();
            a.MoneyCount = 20;
            b.MoneyCount = 20;

            Mediator mediator = new ConcreteMediator(a, b);

            a.ChangeCount(5, mediator);
            Assert.Equal(25, a.MoneyCount);
            Assert.Equal(15, b.MoneyCount);

            b.ChangeCount(10, mediator);
            Assert.Equal(15, a.MoneyCount);
            Assert.Equal(25, b.MoneyCount);
        }
    }
}
