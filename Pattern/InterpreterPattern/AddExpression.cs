using System.Collections.Generic;

namespace Pattern.InterpreterPattern
{
    public class AddExpression : SymbolExpression
    {
        public AddExpression(Expression left, Expression right)
            : base(left, right)
        {
        }

        public override int Interpreter(IDictionary<string, int> dic)
        {
            return left.Interpreter(dic) + right.Interpreter(dic);
        }
    }
}
