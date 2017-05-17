using Pattern.FactoryMethodPattern;
using System.Collections.Generic;
using Xunit;

namespace Pattern.Test
{
    public class FactoryMethodPatternTest
    {
        [Theory]
        [MemberData("TestData")]
        public void Test(Factory factory, string expectedProductName)
        {
            Product product = factory.Make();
            Assert.NotNull(product);
            Assert.Equal(expectedProductName, product.Name);
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                return new[]
                {
                    new object[] { new CarFactory(), "Car" },
                    new object[] { new GameFactory(), "Game" }
                };
            }
        }
    }
}
