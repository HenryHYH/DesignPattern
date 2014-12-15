using Xunit.Extensions;
using Xunit.Should;

namespace Pattern.Test
{
    public class Helloworld
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, -1, 0)]
        public void Test(int a, int b, int expect)
        {
            (a + b).ShouldBe(expect);
        }
    }
}
