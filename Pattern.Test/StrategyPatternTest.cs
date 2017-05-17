using Pattern.StrategyPattern;
using Xunit;

namespace Pattern.Test
{
    public class StrategyPatternTest
    {
        [Fact]
        public void Test()
        {
            // http://www.cnblogs.com/zhili/p/StragetyPattern.html

            InterestOperation operation = new InterestOperation(new PersonalTaxStrategy());
            Assert.Equal(600, operation.GetTax(5000));

            operation = new InterestOperation(new EnterpriseTaxStrategy());
            Assert.Equal(67.5, operation.GetTax(5000));
        }
    }
}
