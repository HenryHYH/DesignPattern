using Pattern.BridgePattern;
using System.Collections.Generic;
using Xunit;

namespace Pattern.Test
{
    public class BridgePatternTest
    {
        [Theory]
        [MemberData("TestData")]
        public void Test(TV tv, string expectedOn, string expectedOff)
        {
            RemoteControl control = new XiaomiRemoteControl(tv);
            Assert.Equal(expectedOn, control.On());
            Assert.Equal(expectedOff, control.Off());
        }

        public static IEnumerable<object[]> TestData
        {
            get
            {
                return new[]
                {
                    new object[] { new XiaomiTV(), "XiaomiTV on", "XiaomiTV off" },
                    new object[] { new AppleTV(), "AppleTV on", "AppleTV off" }
                };
            }
        }
    }
}
