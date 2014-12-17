using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CompositePattern
{
    public class Line : Graphics
    {
        public Line(string color)
            : base(color)
        {
        }

        public override string Draw()
        {
            return Color + " line";
        }
    }
}
