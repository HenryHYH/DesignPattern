using Pattern.AbstractFactoryPattern;
using System.Collections.Generic;
using Xunit;

namespace Pattern.Test
{
    public class AbstractFactoryPatternTest
    {
        [Theory]
        [MemberData("TestData")]
        public void Test(Factory factory, string expectedOS, string expectedConnectionType)
        {
            var phone = factory.MakePhone();
            Assert.Equal(expectedOS, phone.OS);

            var adapter = factory.MakeAdapter();
            Assert.Equal(expectedConnectionType, adapter.ConnectionType);
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
