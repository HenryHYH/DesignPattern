using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;
using Pattern.CompositePattern;

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

            g.Draw().ShouldBe("Green line + Red circle");

            g.Remove(greenLine);
            g.Draw().ShouldBe("Red circle");
        }
    }
}
