using Pattern.VistorPattern;
using Xunit;

namespace Pattern.Test
{
    public class VistiorPatternTest
    {
        [Fact]
        public void Test()
        {
            var objStructure = new ObjectStructure();
            foreach (var item in objStructure.Elements)
                item.Accept(new ConcreteVisitor());

            Assert.Equal(1, 1);
        }
    }
}
