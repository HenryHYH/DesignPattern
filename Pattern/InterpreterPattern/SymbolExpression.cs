namespace Pattern.InterpreterPattern
{
    public abstract class SymbolExpression : Expression
    {
        protected readonly Expression left;
        protected readonly Expression right;

        public SymbolExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
