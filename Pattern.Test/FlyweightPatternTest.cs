using Pattern.FlyweightPattern;
using Xunit;

namespace Pattern.Test
{
    public class FlyweightPatternTest
    {
        [Fact]
        public void Test()
        {
            // http://www.cnblogs.com/zhili/p/FlyweightPattern.html

            int extState = 10;
            var factory = new FlyweightFactory();
            var testDatas = new[] { "A", "B", "C", "D" };

            for (int i = 0, iMax = testDatas.Length; i < iMax; i++)
            {
                var key = testDatas[i];
                var flyweight = factory.GetFlyweight(key);
                if (null != flyweight)
                    flyweight.Operation(--extState);
                Assert.Equal(9 - i, extState);
            }
        }

        [Fact]
        public void Test_Coffee_Shop()
        {
            // http://www.cnblogs.com/zhenyulu/articles/55793.html

            var factory = new FlavorFactory();
            var ordersMade = 0;
            var flavors = new[] {
                "Black Coffee",
                "Capucino",
                "Espresso",
                "Capucino",
                "Espresso",
                "Black Coffee",
                "Espresso",
                "Espresso",
                "Black Coffee",
                "Capucino",
                "Capucino",
                "Black Coffee"
            };

            foreach (var item in flavors)
            {
                var order = factory.GetOrder(item);
                order.Serve(new Table(++ordersMade));
            }

            Assert.Equal(flavors.Length, ordersMade);
            Assert.Equal(3, factory.GetTotalFlavors());
        }
    }
}
