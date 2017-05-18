namespace Pattern.VistorPattern
{
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            element.Print();
        }
    }
}
