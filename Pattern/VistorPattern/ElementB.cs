using System;

namespace Pattern.VistorPattern
{
    public class ElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("Element B");
        }
    }
}
