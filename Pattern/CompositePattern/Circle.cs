using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CompositePattern
{
    public class Circle : Graphics
    {
        public Circle(string color)
            : base(color)
        { }

        public override string Draw()
        {
            return Color + " circle";
        }
    }
}
