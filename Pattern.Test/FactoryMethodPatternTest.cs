using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Pattern.FactoryMethodPattern;
using Xunit.Should;
using Xunit.Extensions;

namespace Pattern.Test
{
    public class FactoryMethodPatternTest
    {
        [Theory]
        [PropertyData("TestData")]
        public void Test(Factory factory, string expectedProductName)
        {
            Product product = factory.Make();
            product.ShouldNotBeNull();
            product.Name.ShouldBe(expectedProductName);
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
