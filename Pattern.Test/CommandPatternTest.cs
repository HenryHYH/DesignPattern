using Pattern.CommonPattern;
using Xunit;

namespace Pattern.Test
{
    public class CommandPatternTest
    {
        [Fact]
        public void Test()
        {
            // http://www.cnblogs.com/zhili/p/CommandPattern.html

            Receiver receiver = new Receiver();
            Command command = new ConcerteCommand(receiver);
            Invoker invoker = new Invoker(command);

            invoker.ExecuteCommand();

            Assert.Equal(1, 1);
        }
    }
}
