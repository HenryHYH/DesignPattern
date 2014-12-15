using Pattern.AbstractFactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace Pattern.Test
{
    public class AbstractFactoryPatternTest
    {
        [Theory]
        [PropertyData("TestData")]
        public void Test(Factory factory, string expectedOS, string expectedConnectionType)
        {
            var phone = factory.MakePhone();
            phone.OS.ShouldBe(expectedOS);

            var adapter = factory.MakeAdapter();
            adapter.ConnectionType.ShouldBe(expectedConnectionType);
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                return new[]
                {
                    new object[] { new XiaomiFactory(), "MIUI v6", "USB" },
                    new object[] { new AppleFactory(), "IOS 8", "Lightning" }
                };
            }
        }
    }
}
