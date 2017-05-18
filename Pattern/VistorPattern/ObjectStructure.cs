using System;
using System.Collections.Generic;

namespace Pattern.VistorPattern
{
    public class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public IList<Element> Elements
        {
            get { return elements; }
        }

        public ObjectStructure()
        {
            var rand = new Random();
            for (var i = 0; i < 6; i++)
            {
                int randNum = rand.Next(10);
                if (randNum > 5)
                    elements.Add(new ElementA());
                else
                    elements.Add(new ElementB());
            }
        }
    }
}
