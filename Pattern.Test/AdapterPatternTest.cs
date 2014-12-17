using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.AdapterPattern;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace Pattern.Test
{
    public class AdapterPatternTest
    {
        [Theory]
        [PropertyData("TestData")]
        public void TestClassAdapter(IThreeHole threeHole)
        {
            threeHole.GetPowerFromThreeHole().ShouldBe("Power");
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
