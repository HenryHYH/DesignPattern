using Pattern.SimpleFactoryPattern;
using System;
using Xunit;

namespace Pattern.Test
{
    public class SimpleFactoryPatternTest
    {
        [Theory]
        [InlineData("Car")]
        [InlineData("Game")]
        public void Test(string productName)
        {
            var product = Facotry.Make(productName);
            Assert.NotNull(product);
            Assert.Equal(productName, product.Name);
        }

        [Fact]
        public void TestError()
        {
            Assert.Throws<ArgumentNullException>(() => Facotry.Make(null));
            Assert.Throws<ArgumentException>(() => Facotry.Make("Nothing"));
        }
    }
}
