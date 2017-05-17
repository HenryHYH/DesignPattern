using Pattern.AdapterPattern;
using System;
using System.Collections.Generic;
using Xunit;

namespace Pattern.Test
{
    public class AdapterPatternTest
    {
        [Theory]
        [MemberData("TestData")]
        public void TestClassAdapter(IThreeHole threeHole)
        {
            Assert.Equal("Power", threeHole.GetPowerFromThreeHole());
        }

        public static IEnumerable<Object[]> TestData
        {
            get
            {
                return new[]
                {
                    new object[] { new ClassAdapter() },
                    new object[] { new ObjectAdapter() }
                };
            }
        }
    }
}
