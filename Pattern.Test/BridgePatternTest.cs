using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;
using Pattern.BridgePattern;

namespace Pattern.Test
{
    public class BridgePatternTest
    {
        [Theory]
        [PropertyData("TestData")]
        public void Test(TV tv, string expectedOn, string expectedOff)
        {
            RemoteControl control = new XiaomiRemoteControl(tv);
            control.On().ShouldBe(expectedOn);
            control.Off().ShouldBe(expectedOff);
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
