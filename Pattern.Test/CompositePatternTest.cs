using Pattern.CompositePattern;
using Xunit;

namespace Pattern.Test
{
    public class CompositePatternTest
    {
        [Fact]
        public void Test()
        {
            ComplexGraphics g = new ComplexGraphics();

            Graphics greenLine = new Line("Green");
            g.Add(greenLine);
            Graphics redCircle = new Circle("Red");
            g.Add(redCircle);

            Assert.Equal("Green line + Red circle", g.Draw());

            g.Remove(greenLine);
            Assert.Equal("Red circle", g.Draw());
        }
    }
}
