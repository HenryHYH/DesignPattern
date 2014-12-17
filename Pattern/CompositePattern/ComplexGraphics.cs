using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.CompositePattern
{
    public class ComplexGraphics : Graphics
    {
        private IList<Graphics> graphicsList = new List<Graphics>();

        public ComplexGraphics()
            : base(string.Empty)
        { }

        public override string Draw()
        {
            return string.Join(" + ", graphicsList.Select(x => x.Draw()));
        }

        public void Add(Graphics g)
        {
            graphicsList.Add(g);
        }

        public void Remove(Graphics g)
        {
            graphicsList.Remove(g);
        }
    }
}
