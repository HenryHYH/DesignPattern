using Pattern.SimpleFactoryPattern;
using System;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

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
            product.ShouldNotBeNull();
            product.Name.ShouldBe(productName);
        }

        [Fact]
        public void TestError()
        {
            Assert.Throws<ArgumentNullException>(() => Facotry.Make(null));
            Assert.Throws<ArgumentException>(() => Facotry.Make("Nothing"));
        }
    }
}
