using Pattern.InterpreterPattern;
using System.Collections.Generic;
using Xunit;

namespace Pattern.Test
{
    public class InterpreterPatternTest
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(string expression, IDictionary<string, int> dic, int expected)
        {
            var calc = new Calculator(expression);
            Assert.Equal(expected, calc.Run(dic));
        }

        private static IEnumerable<object[]> TestData()
        {
            yield return new object[]
            {
                "a+b-c",
                new Dictionary<string, int>
                {
                    { "a" , 1 },
                    { "b" , 2 },
                    { "c" , 3 }
                },
                0
            };
        }
    }
}
