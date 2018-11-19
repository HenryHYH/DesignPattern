using System.Collections.Generic;

namespace Pattern.InterpreterPattern
{
    public class Calculator
    {
        private readonly Expression expression;

        public Calculator(string strExp)
        {
            var stack = new Stack<Expression>();
            var charArray = strExp.ToCharArray();

            Expression left = null;
            Expression right = null;

            for (int i = 0, iMax = charArray.Length; i < iMax; i++)
            {
                if ('+' == charArray[i])
                {
                    left = stack.Pop();
                    right = new VarExpression(charArray[++i].ToString());
                    stack.Push(new AddExpression(left, right));
                }
                else if ('-' == charArray[i])
                {
                    left = stack.Pop();
                    right = new VarExpression(charArray[++i].ToString());
                    stack.Push(new SubExpression(left, right));
                }
                else
                    stack.Push(new VarExpression(charArray[i].ToString()));
            }

            expression = stack.Pop();
        }

        public int Run(IDictionary<string, int> dic)
        {
            return expression.Interpreter(dic);
        }
    }
}
