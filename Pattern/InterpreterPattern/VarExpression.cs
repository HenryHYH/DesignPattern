using System.Collections.Generic;

namespace Pattern.InterpreterPattern
{
    public class VarExpression : Expression
    {
        private readonly string key;

        public VarExpression(string key)
        {
            this.key = key;
        }

        public override int Interpreter(IDictionary<string, int> dic)
        {
            return dic[key];
        }
    }
}
