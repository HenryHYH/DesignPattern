using Pattern.PrototypePattern;
using System;
using Xunit;

namespace Pattern.Test
{
    public class PrototypePatternTest
    {
        [Fact]
        public void Test()
        {
            MonkeyKingPrototype prototype = new ConcretePrototype("MonkeyKing");

            MonkeyKingPrototype clone1 = prototype.Clone();
            Console.WriteLine("Clone1 = " + clone1.Id);

            MonkeyKingPrototype clone2 = prototype.Clone();
            Console.WriteLine("Clone2 = " + clone2.Id);

            Assert.Equal(1, 1);
        }
    }
}
