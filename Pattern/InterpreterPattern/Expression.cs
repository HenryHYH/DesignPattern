using System.Collections.Generic;

namespace Pattern.InterpreterPattern
{
    public abstract class Expression
    {
        public abstract int Interpreter(IDictionary<string, int> dic);
    }
}
