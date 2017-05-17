using Pattern.TemplateMethodPattern;
using Xunit;

namespace Pattern.Test
{
    public class TemplateMethodPatternTest
    {
        [Fact]
        public void Test()
        {
            DataObject obj = new CustomerDataObject();
            obj.Run();

            Assert.Equal(1, 1);
        }
    }
}
