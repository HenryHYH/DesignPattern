using Pattern.CommandPattern.CalculatorDemo;
using Pattern.CommandPattern.Common;
using Xunit;

namespace Pattern.Test
{
    public class CommandPatternTest
    {
        [Fact]
        public void Test()
        {
            // http://www.cnblogs.com/zhili/p/CommandPattern.html

            var receiver = new Receiver();
            var command = new ConcerteCommand(receiver);
            var invoker = new Invoker(command);

            invoker.ExecuteCommand();

            Assert.Equal(1, 1);
        }

        [Fact]
        public void Test_Calculator()
        {
            var user = new User();

            var result = user.Compute('+', 100);
            Assert.Equal(100, result);

            result = user.Compute('-', 50);
            Assert.Equal(50, result);

            result = user.Compute('*', 10);
            Assert.Equal(500, result);

            result = user.Compute('/', 2);
            Assert.Equal(250, result);

            user.Undo(4);
            user.Redo(3);

            Assert.Equal(1, 1);
        }
    }
}
