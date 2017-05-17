using Xunit;

namespace Pattern.Test
{
    public class Helloworld
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, -1, 0)]
        public void Test(int a, int b, int expect)
        {
            Assert.Equal(expect, (a + b));
        }
    }
}
