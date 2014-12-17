using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CompositePattern
{
    public abstract class Graphics
    {
        public string Color { get; private set; }

        public Graphics(string color)
        {
            Color = color;
        }

        public abstract string Draw();
    }
}
